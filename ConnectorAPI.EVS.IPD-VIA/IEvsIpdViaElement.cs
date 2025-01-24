namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA
{
	using System;
	using System.Collections.Generic;
	using Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.Element;

	/// <summary>
	/// Interface defining interactions with EVS IPD VIA element.
	/// </summary>
	public interface IEvsIpdViaElement
	{
		/// <summary>
		/// Gets the name of the element.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Gets the time-out configured in the element.
		/// </summary>
		TimeSpan InterAppTimeout { get; }

		/// <summary>
		/// Adds or updates a recording session in EVS.
		/// </summary>
		/// <param name="recordingSession"></param>
		/// <returns></returns>
		RecordingSession AddOrUpdateRecordingSession(RecordingSession recordingSession);

		/// <summary>
		/// Deletes a recording session in EVS.
		/// </summary>
		/// <param name="recordingSessionId"></param>
		void DeleteRecordingSession(string recordingSessionId);

		/// <summary>
		/// Gets all labels from the metadata table.
		/// </summary>
		/// <returns></returns>
		IEnumerable<ProfileField> GetMetadataLabels();

		/// <summary>
		/// Gets all recorders from the Recorders table.
		/// </summary>
		/// <returns></returns>
		IEnumerable<Recorder> GetRecorders();

		/// <summary>
		/// Gets the recording session for the given ID.
		/// </summary>
		/// <param name="recordingSessionId"></param>
		/// <returns></returns>
		RecordingSession GetRecordingSession(string recordingSessionId);

		/// <summary>
		/// Gets all targets.
		/// </summary>
		/// <returns></returns>
		IEnumerable<Target> GetTargets();
	}
}