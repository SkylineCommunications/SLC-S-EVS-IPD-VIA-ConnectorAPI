namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class MetadataOrigin
    {
        [JsonProperty("isInherited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInherited { get; set; }

        [JsonProperty("resourceRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceRef { get; set; }

        [JsonProperty("resourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }
    }
}
