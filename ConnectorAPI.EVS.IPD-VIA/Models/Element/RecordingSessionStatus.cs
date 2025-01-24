namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.Element
{
	using System.ComponentModel;

	/// <summary>
	/// Indicating the status of a recording session.
	/// </summary>
	public enum RecordingSessionStatus
	{
		/// <summary>
		/// Not applicable.
		/// </summary>
		NA = -1,

		/// <summary>
		/// InError.
		/// </summary>
		[Description("RECORDING_SESSION_STATUS_IN_ERROR")]
		InError = 0,

		/// <summary>
		/// Recorded.
		/// </summary>
		[Description("RECORDING_SESSION_STATUS_RECORDED")]
		Recorded = 1,

		/// <summary>
		/// Scheduled.
		/// </summary>
		[Description("RECORDING_SESSION_STATUS_SCHEDULED")]
		Scheduled = 2,

		/// <summary>
		/// Recording.
		/// </summary>
		[Description("RECORDING_SESSION_STATUS_RECORDING")]
		Recording = 5,

		/// <summary>
		/// Unknown.
		/// </summary>
		Unknown = 6,
	}
}
