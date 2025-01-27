namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
	using System.Collections.Generic;
	using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class RecordingMessage
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("recordingSession", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RecordingSessionNotification RecordingSession { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("patch", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Patch Patch { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("deletedRecordingSession", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DeletedRecordingSession DeletedRecordingSession { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("resourceRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceRef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("resourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("profileFqn", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ProfileFqn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("modificationDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ModificationDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Values { get; set; }
    }
}
