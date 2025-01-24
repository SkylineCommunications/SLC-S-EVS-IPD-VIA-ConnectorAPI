namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class RecordingSessionNotification
    {
        public static readonly string RecordingSessionsPath = "/opengate/1/ingest/recording-sessions/";

        [JsonProperty("destinationMediaAssetRef", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationMediaAssetRef { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("recorderRef", NullValueHandling = NullValueHandling.Ignore)]
        public string RecorderRef { get; set; }

        [JsonProperty("requestedIn", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(RequestedJsonConverter))]
        public Requested RequestedIn { get; set; }

        [JsonProperty("requestedOut", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(RequestedJsonConverter))]
        public Requested RequestedOut { get; set; }

        [JsonProperty("sourceMediaAssetRef", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceMediaAssetRef { get; set; }

        [JsonProperty("sourceRef", NullValueHandling = NullValueHandling.Ignore)]
        public object SourceRef { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<TargetRecording> Targets { get; set; }
    }
}
