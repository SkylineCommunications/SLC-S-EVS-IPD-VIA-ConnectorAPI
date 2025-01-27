namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

	/// <summary>
	/// 
	/// </summary>
	public class RecordingSessions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordingSessionNotification> RecordingSessionsItems { get; set; }
    }
}
