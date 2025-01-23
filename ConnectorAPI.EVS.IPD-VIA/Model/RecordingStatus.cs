namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Model
{
	using System.ComponentModel;

	public enum RecordingStatus
    {
        NA = -1,
        [Description("RECORDING_SESSION_STATUS_IN_ERROR")]
        InError = 0,
        [Description("RECORDING_SESSION_STATUS_RECORDED")]
        Recorded = 1,
        [Description("RECORDING_SESSION_STATUS_SCHEDULED")]
        Scheduled = 2,
        [Description("RECORDING_SESSION_STATUS_RECORDING")]
        Recording = 5,
        Unknown = 6,
    }
}
