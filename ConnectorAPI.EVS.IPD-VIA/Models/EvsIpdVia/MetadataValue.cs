namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class MetadataValue
    {
        [JsonProperty("type_", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("jsonValue_", NullValueHandling = NullValueHandling.Ignore)]
        public string JsonValue { get; set; }

        [JsonProperty("label_", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }
    }
}
