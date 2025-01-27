namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public class DeletedRecordingSession
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("recordingSessionRef", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RecordingSessionRef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
    }
}
