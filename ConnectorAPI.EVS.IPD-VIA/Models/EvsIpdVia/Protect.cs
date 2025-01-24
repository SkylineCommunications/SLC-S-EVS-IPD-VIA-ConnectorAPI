namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class Protect
    {
        [JsonProperty("hasValue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasValue { get; set; }
    }
}
