namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;
	using Newtonsoft.Json;
	using Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Messages;
	using Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Model;
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
		/// <summary>
		/// ID of the parameter in the EVS IPD VIA protocol that's used to receive incoming InterApp messages.
		/// </summary>
		public const int InterAppReceive_ParameterId = 9000000;

		private readonly IConnection connection;
		private readonly IDmsElement element;
		private readonly ILogger logger;

		private TimeSpan? timeout;

		private static readonly List<Type> knownTypes = new List<Type>
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
		/// List of known types. Used during InterApp communication.
		/// </summary>
		public static IEnumerable<Type> KnownTypes => knownTypes;

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
		/// Gets the name of the DataMiner element.
		/// </summary>
		public string Name => element.Name;

		/// <summary>
		/// Maximum amount of time in which every request to the EVS element should be handled.
		/// Default: 30 seconds.
		/// </summary>
		public TimeSpan Timeout
		{
			get
			{
				if (timeout != null) return (TimeSpan)timeout;
				try
				{
					var timeoutInSeconds = element.GetStandaloneParameter<double?>(EvsIpdViaProtocol.Parameter.interapptimeout_500) ?? throw new InvalidOperationException("InterApp Timeout value is null.");
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
				RecordingSessionsId = recordingSessionId
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

			var recordingSessionsTable = element.GetTable(EvsIpdViaProtocol.Parameter.Recordingsessions.tablePid);
			var row = recordingSessionsTable.GetRow(recordingSessionId);

			var recordingSession = new RecordingSession
			{
				Id = Convert.ToString(row[EvsIpdViaProtocol.Parameter.Recordingsessions.Idx.recordingsessionsinstance_1401]),
				Name = Convert.ToString(row[EvsIpdViaProtocol.Parameter.Recordingsessions.Idx.recordingsessionsname_1402]),
				Start = DateTime.SpecifyKind(DateTime.FromOADate(Convert.ToDouble(row[EvsIpdViaProtocol.Parameter.Recordingsessions.Idx.recordingsessionsdatein])), DateTimeKind.Local),
				End = DateTime.SpecifyKind(DateTime.FromOADate(Convert.ToDouble(row[EvsIpdViaProtocol.Parameter.Recordingsessions.Idx.recordingsessionsdateout])), DateTimeKind.Local),
				Recorder = Convert.ToString(row[EvsIpdViaProtocol.Parameter.Recordingsessions.Idx.recordingsessionsrecordername]),
				Status = (RecordingStatus)(Convert.ToInt32(row[EvsIpdViaProtocol.Parameter.Recordingsessions.Idx.recordingsessionsstatus])),
				Targets = GetTargetsOfRecordingSession(recordingSessionId),
				Metadata = GetMetadataOfRecordingSession(recordingSessionId).Values.ToList()
			};

			return recordingSession;
		}

		/// <summary>
		/// Gets the available recorders from the Recorders table from the element.
		/// </summary>
		/// <returns>List of available recorders.</returns>
		public IEnumerable<Recorder> GetRecorders()
		{
			var recordersTable = element.GetTable(EvsIpdViaProtocol.Parameter.Recorders.tablePid)?.GetData();

			return recordersTable.Select(x => new Recorder { Id = x.Key, Name = Convert.ToString(x.Value[EvsIpdViaProtocol.Parameter.Recorders.Idx.recordersname]) }).ToList();
		}

		/// <summary>
		/// Gets the names of the available targets from the Targets table from the element.
		/// </summary>
		/// <returns>List of target names.</returns>
		public IEnumerable<string> GetTargetNames()
		{
			var targetsTable = element.GetTable(EvsIpdViaProtocol.Parameter.Targets.tablePid).GetData();

			return targetsTable.Values.Select(x => Convert.ToString(x[EvsIpdViaProtocol.Parameter.Targets.Idx.targetsname])).ToList();
		}

		/// <summary>
		/// Retrieves the metadata labels from the Profile Fields table.
		/// </summary>
		/// <returns>All labels from the Profile Fields table.</returns>
		public IEnumerable<Label> GetMetadataLabels()
		{
			var profileFieldsTable = element.GetTable(EvsIpdViaProtocol.Parameter.Profilefields.tablePid);

			return profileFieldsTable.GetData().Values.Select(x => new Label
			{
				Key = Convert.ToString(x[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldskey]),
				Name = Convert.ToString(x[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldslabel]),
				Type = Convert.ToString(x[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldstype]),
				Required = Convert.ToBoolean(x[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldsrequired]),
				ProfileFqn = Convert.ToString(x[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldsprofilefqn]),
				ProfileName = Convert.ToString(x[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldsprofilename])
			}).ToList();
		}

		private Dictionary<string, Metadata> GetMetadataOfRecordingSession(string recordingSessionId)
		{
			var metaDataTable = element.GetTable(EvsIpdViaProtocol.Parameter.Recordingsessionsmetadatavalues.tablePid);
			var metaDataEntries = metaDataTable.QueryData(new[]
			{
				new ColumnFilter
				{
					Pid = EvsIpdViaProtocol.Parameter.Recordingsessionsmetadatavalues.Pid.recordingsessionsmetadatavaluesrecordingsessionid,
					ComparisonOperator = ComparisonOperator.Equal,
					Value = recordingSessionId
				}
			});

			var profileFieldsTableData = element.GetTable(EvsIpdViaProtocol.Parameter.Profilefields.tablePid).GetData();
			Dictionary<string, Metadata> metadataToStore = new Dictionary<string, Metadata>();
			foreach (var metaDataEntry in metaDataEntries)
			{
				string profileFqn = Convert.ToString(metaDataEntry[EvsIpdViaProtocol.Parameter.Recordingsessionsmetadatavalues.Idx.recordingsessionsmetadatavaluesprofile]);
				string label = Convert.ToString(metaDataEntry[EvsIpdViaProtocol.Parameter.Recordingsessionsmetadatavalues.Idx.recordingsessionsmetadatavalueskey]);
				string value = Convert.ToString(metaDataEntry[EvsIpdViaProtocol.Parameter.Recordingsessionsmetadatavalues.Idx.recordingsessionsmetadatavaluesvalue]);

				string key = GetProfileFieldKey(profileFqn, label, profileFieldsTableData.Values);
				if (String.IsNullOrWhiteSpace(key)) continue;

				if (metadataToStore.TryGetValue(profileFqn, out Metadata metadata))
				{
					metadata.Values[key] = value;
				}
				else
				{
					metadataToStore.Add(profileFqn, new Metadata
					{
						Profile = profileFqn,
						Values = new Dictionary<string, string>
						{
							{ key, value }
						}
					});
				}
			}

			return metadataToStore;
		}

		private IEnumerable<string> GetTargetsOfRecordingSession(string recordingSessionId)
		{
			var recordingSessionsTargetsTable = element.GetTable(EvsIpdViaProtocol.Parameter.Recordingsessionstargets.tablePid);

			var targets = recordingSessionsTargetsTable.QueryData(new[]
			{
				new ColumnFilter
				{
					Pid = EvsIpdViaProtocol.Parameter.Recordingsessionstargets.Pid.recordingsessionstargetsrecordingsessioninstance,
					ComparisonOperator = ComparisonOperator.Equal,
					Value = recordingSessionId
				}
			}).Select(x => Convert.ToString(x[EvsIpdViaProtocol.Parameter.Recordingsessionstargets.Idx.recordingsessionstargetstarget])).ToArray();

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
					var response = commands.Send(connection, element.AgentId, element.Id, InterAppReceive_ParameterId, Timeout, knownTypes).First();
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
					commands.Send(connection, element.AgentId, element.Id, InterAppReceive_ParameterId, knownTypes);
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
				string rowProfileFqn = Convert.ToString(row[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldsprofilefqn]);
				string rowProfileFieldLabel = Convert.ToString(row[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldslabel]);

				if (String.Equals(profileFqn, rowProfileFqn, StringComparison.InvariantCultureIgnoreCase) && String.Equals(profileFieldLabel, rowProfileFieldLabel, StringComparison.InvariantCultureIgnoreCase))
				{
					return Convert.ToString(row[EvsIpdViaProtocol.Parameter.Profilefields.Idx.profilefieldskey]);
				}
			}

			return String.Empty;
		}
	}
}
