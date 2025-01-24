namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class TargetParametersTarget
    {
        [JsonProperty("xsquareId", NullValueHandling = NullValueHandling.Ignore)]
        public string XsquareId { get; set; }

        [JsonProperty("xsquareTargetId", NullValueHandling = NullValueHandling.Ignore)]
        public string XsquareTargetId { get; set; }
    }
}
