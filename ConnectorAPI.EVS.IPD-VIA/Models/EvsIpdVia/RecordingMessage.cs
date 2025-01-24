namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class RecordingMessage
    {
        [JsonProperty("recordingSession", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RecordingSessionNotification RecordingSession { get; set; }

        [JsonProperty("patch", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Patch Patch { get; set; }

        [JsonProperty("deletedRecordingSession", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DeletedRecordingSession DeletedRecordingSession { get; set; }

        [JsonProperty("resourceRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceRef { get; set; }

        [JsonProperty("resourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        [JsonProperty("profileFqn", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ProfileFqn { get; set; }

        [JsonProperty("modificationDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ModificationDate { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Values { get; set; }
    }
}
