namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class RecordingSessions
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordingSessionNotification> RecordingSessionsItems { get; set; }
    }
}
