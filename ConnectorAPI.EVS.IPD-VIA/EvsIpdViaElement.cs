namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;
	using Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.Element;
	using Newtonsoft.Json;
	using Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Messages;
	using Skyline.DataMiner.Core.DataMinerSystem.Common;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
	using Skyline.DataMiner.Net;

	/// <summary>
	/// Represents an EVS IPD VIA element in DataMiner.
	/// </summary>
	public class EvsIpdViaElement : IEvsIpdViaElement
	{
		private readonly IConnection connection;
		private readonly IDmsElement element;
		private readonly ILogger logger;

		private TimeSpan? timeout;

		/// <summary>
		/// Initializes a new instance of the <see cref="EvsIpdViaElement"/> class.
		/// </summary>
		/// <param name="connection">Connection used to communicate with the EVS element.</param>
		/// <param name="agentId">ID of the agent on which the EVS element is hosted.</param>
		/// <param name="elementId">ID of the EVS element.</param>
		/// <param name="logger">Object that inherits ILogger interface used to log info if needed.</param>
		/// <exception cref="ArgumentNullException">Thrown when the provided connection or the element is null.</exception>
		/// <exception cref="InvalidOperationException">Thrown when described element is inactive.</exception>
		public EvsIpdViaElement(IConnection connection, int agentId, int elementId, ILogger logger = null)
		{
			this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
			element = connection.GetDms().GetElement(new DmsElementId(agentId, elementId));
			this.logger = logger;
			if (element.State != ElementState.Active) throw new InvalidOperationException($"Element {element.Name} is not active");
		}

		/// <summary>
		/// List of known types. Used during InterApp communication.
		/// </summary>
		public static IReadOnlyCollection<Type> KnownTypes { get; } = new List<Type>
		{
			typeof(AddOrUpdateRecordingSession),
			typeof(AddOrUpdateRecordingSessionResult),
			typeof(DeleteRecordingSession),
			typeof(RecordingSession),
			typeof(Metadata),
			typeof(List<Metadata>),
			typeof(Metadata[]),
			typeof(Dictionary<string, string>),
			typeof(ReturnAddress)
		};

		/// <summary>
		/// Gets the name of the DataMiner element.
		/// </summary>
		public string Name => element.Name;

		/// <summary>
		/// Maximum amount of time in which every request to the EVS element should be handled.
		/// Default: 30 seconds.
		/// </summary>
		public TimeSpan InterAppTimeout
		{
			get
			{
				if (timeout != null) return (TimeSpan)timeout;
				try
				{
					var timeoutInSeconds = element.GetStandaloneParameter<double?>(EvsIpdViaProtocol.InterAppTimeout) ?? throw new InvalidOperationException("InterApp Timeout value is null.");
					timeout = TimeSpan.FromSeconds(timeoutInSeconds.GetValue().Value);
					Log($"Timeout timespan: {timeout}");
					return (TimeSpan)timeout;
				}
				catch (Exception e)
				{
					timeout = TimeSpan.FromSeconds(30);
					Log($"Unable to retrieve timeout due to: {e}");
					return (TimeSpan)timeout;
				}
			}
		}

		/// <summary>
		/// Adds or updates a recording session in the EVS system.
		/// If the ID of the recording session does not exist in EVS, a new recording session is created, else the existing one is updated.
		/// This method uses InterApp to forward the recording session to EVS.
		/// </summary>
		/// <param name="recordingSession">Recording session to add or update.</param>
		/// <returns>Updated recording session from EVS.</returns>
		/// <exception cref="ArgumentNullException">If recording session is null.</exception>
		/// <exception cref="InvalidOperationException">If InterApp communication fails.</exception>
		public RecordingSession AddOrUpdateRecordingSession(RecordingSession recordingSession)
		{
			if (recordingSession == null) throw new ArgumentNullException(nameof(recordingSession));

			var message = new AddOrUpdateRecordingSession
			{
				RecordingSession = recordingSession
			};

			if (!TrySendMessage(message, true, out string reason, out AddOrUpdateRecordingSessionResult result))
			{
				throw new InvalidOperationException($"Unable to add or update recording session with id {recordingSession.Id} due to {reason}");
			}

			if (!result.Success)
			{
				throw new InvalidOperationException($"Unable to add or update recording session with id {recordingSession.Id} due to {result.ErrorMessage}");
			}

			return result.RecordingSession;
		}

		/// <summary>
		/// Deletes a recording session from the EVS system.
		/// This method uses InterApp to delete the recording session from EVS.
		/// </summary>
		/// <param name="recordingSessionId">ID of the recording session to remove.</param>
		/// <exception cref="ArgumentException">If recording session id is null or whitespace.</exception>
		/// <exception cref="InvalidOperationException">If InterApp communication fails.</exception>
		public void DeleteRecordingSession(string recordingSessionId)
		{
			if (String.IsNullOrWhiteSpace(recordingSessionId)) throw new ArgumentException(nameof(recordingSessionId));

			var message = new DeleteRecordingSession
			{
				RecordingSessionId = recordingSessionId
			};

			if (!TrySendMessage(message, false, out string reason, out Message _))
			{
				throw new InvalidOperationException($"Unable to delete recording session with id {recordingSessionId} due to {reason}");
			}
		}

		/// <summary>
		/// Retrieves a recording session from the EVS element.
		/// All data is retrieved from the tables available in the element.
		/// </summary>
		/// <param name="recordingSessionId">ID of the recording session to retrieve.</param>
		/// <returns>Recording session with given ID.</returns>
		/// <exception cref="ArgumentException">If recording session ID is null or whitespace.</exception>
		public RecordingSession GetRecordingSession(string recordingSessionId)
		{
			if (String.IsNullOrWhiteSpace(recordingSessionId)) throw new ArgumentException(nameof(recordingSessionId));

			var recordingSessionsTable = element.GetTable(EvsIpdViaProtocol.RecordingSessionsTable.TablePid);
			var row = recordingSessionsTable.GetRow(recordingSessionId);

			var recordingSession = new RecordingSession
			{
				Id = Convert.ToString(row[EvsIpdViaProtocol.RecordingSessionsTable.Idx.RecordingSessionsInstance]),
				Name = Convert.ToString(row[EvsIpdViaProtocol.RecordingSessionsTable.Idx.RecordingSessionsNameIdx]),
				Start = DateTime.SpecifyKind(DateTime.FromOADate(Convert.ToDouble(row[EvsIpdViaProtocol.RecordingSessionsTable.Idx.RecordingSessionsStartIdx])), DateTimeKind.Local),
				End = DateTime.SpecifyKind(DateTime.FromOADate(Convert.ToDouble(row[EvsIpdViaProtocol.RecordingSessionsTable.Idx.RecordingSessionsEndIdx])), DateTimeKind.Local),
				Recorder = GetRecorder(Convert.ToString(row[EvsIpdViaProtocol.RecordingSessionsTable.Idx.RecordingSessionsRecorderIdIdx])),
				Status = (RecordingSessionStatus)Convert.ToInt32(row[EvsIpdViaProtocol.RecordingSessionsTable.Idx.RecordingSessionsStatusIdx]),
				Targets = GetTargetsOfRecordingSession(recordingSessionId),
				Metadata = GetMetadataOfRecordingSession(recordingSessionId).Values.ToList(),
			};

			return recordingSession;
		}

		/// <summary>
		/// Gets the recorder for the given ID.
		/// </summary>
		/// <param name="recorderId"></param>
		public Recorder GetRecorder(string recorderId)
		{
			var recorderRow = element.GetTable(EvsIpdViaProtocol.RecordersTable.TablePid).GetRow(recorderId);

			return new Recorder
			{
				Id = recorderId,
				Name = Convert.ToString(recorderRow[EvsIpdViaProtocol.RecordersTable.Idx.RecordersName])
			};
		}

		/// <summary>
		/// Gets the available recorders from the Recorders table from the element.
		/// </summary>
		/// <returns>List of available recorders.</returns>
		public IEnumerable<Recorder> GetRecorders()
		{
			var recordersTable = element.GetTable(EvsIpdViaProtocol.RecordersTable.TablePid)?.GetData();

			return recordersTable.Select(x => new Recorder { Id = x.Key, Name = Convert.ToString(x.Value[EvsIpdViaProtocol.RecordersTable.Idx.RecordersName]) }).ToList();
		}

		/// <summary>
		/// Gets the names of the available targets from the Targets table from the element.
		/// </summary>
		/// <returns>List of target names.</returns>
		public IEnumerable<Target> GetTargets()
		{
			var targetsTable = element.GetTable(EvsIpdViaProtocol.TargetsTable.TablePid).GetData();

			return targetsTable.Values.Select(row => 
				new Target
				{
					Instance = Convert.ToString(row[EvsIpdViaProtocol.TargetsTable.Idx.TargetsInstance]),
					Name = Convert.ToString(row[EvsIpdViaProtocol.TargetsTable.Idx.TargetsName]),
				}
			).ToList();
		}

		/// <summary>
		/// Retrieves the metadata labels from the Profile Fields table.
		/// </summary>
		/// <returns>All labels from the Profile Fields table.</returns>
		public IEnumerable<ProfileField> GetMetadataLabels()
		{
			var profileFieldsTable = element.GetTable(EvsIpdViaProtocol.ProfileFieldsTable.TablePid);

			return profileFieldsTable.GetData().Values.Select(row => new ProfileField
			{
				Instance = Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsInstance]),
				Key = Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsKey]),
				ProfileFullyQualifiedName = Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsProfileFqn]),
				Label = Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsLabel]),
				Type = Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsType]),
				Required = Convert.ToBoolean(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsRequired]),
				ProfileName = Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsProfileName])
			}).ToList();
		}

		private Dictionary<string, Metadata> GetMetadataOfRecordingSession(string recordingSessionId)
		{
			var recordingSessionsMetadataValuesTable = element.GetTable(EvsIpdViaProtocol.RecordingSessionsMetadataValuesTable.TablePid);
			
			var metadataValueForRecordingSessionRows = recordingSessionsMetadataValuesTable.QueryData(new[]
			{
				new ColumnFilter
				{
					Pid = EvsIpdViaProtocol.RecordingSessionsMetadataValuesTable.Pid.RecordingSessionsMetadataValuesRecordingSessionId,
					ComparisonOperator = ComparisonOperator.Equal,
					Value = recordingSessionId
				}
			});

			var profileFieldsTableData = element.GetTable(EvsIpdViaProtocol.ProfileFieldsTable.TablePid).GetData();
			
			var result = new Dictionary<string, Metadata>();
			
			foreach (var metadataValueRow in metadataValueForRecordingSessionRows)
			{
				string profileFqn = Convert.ToString(metadataValueRow[EvsIpdViaProtocol.RecordingSessionsMetadataValuesTable.Idx.RecordingSessionsMetadataValuesProfile]);
				string label = Convert.ToString(metadataValueRow[EvsIpdViaProtocol.RecordingSessionsMetadataValuesTable.Idx.RecordingSessionsMetadataValuesKey]);
				string value = Convert.ToString(metadataValueRow[EvsIpdViaProtocol.RecordingSessionsMetadataValuesTable.Idx.RecordingSessionsMetadataValuesValue]);

				string key = GetProfileFieldKey(profileFqn, label, profileFieldsTableData.Values);
				if (String.IsNullOrWhiteSpace(key)) continue;

				if (!result.TryGetValue(profileFqn, out var metadata))
				{
					metadata = new Metadata
					{
						ProfileFullyQualifiedName = profileFqn,
						Values = new Dictionary<string, string>(),
					};

					result.Add(profileFqn, metadata);
				}

				metadata.Values[key] = value;
			}

			return result;
		}

		private IEnumerable<Target> GetTargetsOfRecordingSession(string recordingSessionId)
		{
			var recordingSessionsTargetsTable = element.GetTable(EvsIpdViaProtocol.RecordingSessionsTargetsTable.TablePid);

			var recordingSessionTargetRows = recordingSessionsTargetsTable.QueryData(new[]
			{
				new ColumnFilter
				{
					Pid = EvsIpdViaProtocol.RecordingSessionsTargetsTable.Pid.RecordingSessionsTargetsRecordingSessionInstance,
					ComparisonOperator = ComparisonOperator.Equal,
					Value = recordingSessionId
				}
			});
			
			var targets = new List<Target>();

			foreach (var row in recordingSessionTargetRows)
			{
				targets.Add(new Target
				{
					Instance = Convert.ToString(row[EvsIpdViaProtocol.RecordingSessionsTargetsTable.Idx.RecordingSessionsTargetsTargetInstance]),
					Name = Convert.ToString(row[EvsIpdViaProtocol.RecordingSessionsTargetsTable.Idx.RecordingSessionsTargetsTarget])
				});
			}
			
			return targets;
		}

		private bool TrySendMessage<T>(Message message, bool requiresResponse, out string reason, out T responseMessage) where T : Message
		{
			reason = String.Empty;
			responseMessage = default(T);

			var commands = InterAppCallFactory.CreateNew();
			commands.Messages.Add(message);

			Log($"Message: {JsonConvert.SerializeObject(message)}");

			try
			{
				if (requiresResponse)
				{
					var response = commands.Send(connection, element.AgentId, element.Id, EvsIpdViaProtocol.InterAppReceive, InterAppTimeout, KnownTypes).First();
					if (!(response is T castResponse))
					{
						reason = $"Received response is not of type {typeof(T)}";
						return false;
					}

					Log($"Response: {JsonConvert.SerializeObject(response)}");
					responseMessage = castResponse;
				}
				else
				{
					commands.Send(connection, element.AgentId, element.Id, EvsIpdViaProtocol.InterAppReceive, KnownTypes);
				}
			}
			catch (Exception e)
			{
				reason = e.ToString();
				return false;
			}

			return true;
		}

		/// <summary>
		/// Log info that will be used for debug. If logObject is null, log method won't provide any logging.
		/// </summary>
		/// <param name="message">Message that will be logged.</param>
		private void Log(string message)
		{
			if (logger == null) return;

			string nameOfMethod = new StackTrace().GetFrame(1).GetMethod().Name;

			logger.Log(this.GetType().Name, nameOfMethod, message);
		}

		private static string GetProfileFieldKey(string profileFqn, string profileFieldLabel, IEnumerable<object[]> profileFieldsRows)
		{
			foreach (var row in profileFieldsRows)
			{
				string rowProfileFqn = Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsProfileFqn]);
				string rowProfileFieldLabel = Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsLabel]);

				if (String.Equals(profileFqn, rowProfileFqn, StringComparison.InvariantCultureIgnoreCase) && String.Equals(profileFieldLabel, rowProfileFieldLabel, StringComparison.InvariantCultureIgnoreCase))
				{
					return Convert.ToString(row[EvsIpdViaProtocol.ProfileFieldsTable.Idx.ProfileFieldsKey]);
				}
			}

			return String.Empty;
		}
	}
}
