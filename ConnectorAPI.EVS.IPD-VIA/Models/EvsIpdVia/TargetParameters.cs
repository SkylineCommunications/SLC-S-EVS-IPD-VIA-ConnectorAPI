namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class TargetParameters
    {
        [JsonProperty("storageRefs", NullValueHandling = NullValueHandling.Ignore)]
        public string[] StorageRefs { get; set; }

        [JsonProperty("lowresStorageRefs", NullValueHandling = NullValueHandling.Ignore)]
        public LowresStorageRefs LowresStorageRefs { get; set; }

        [JsonProperty("protect", NullValueHandling = NullValueHandling.Ignore)]
        public Protect Protect { get; set; }

        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public TargetParametersTarget Target { get; set; }

        [JsonProperty("browseAgent", NullValueHandling = NullValueHandling.Ignore)]
        public string BrowseAgent { get; set; }

        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public Template Template { get; set; }
    }
}
