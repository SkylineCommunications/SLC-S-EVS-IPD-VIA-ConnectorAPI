namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class LowresStorageRefs
    {
        [JsonProperty("hasValue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasValue { get; set; }
    }
}
