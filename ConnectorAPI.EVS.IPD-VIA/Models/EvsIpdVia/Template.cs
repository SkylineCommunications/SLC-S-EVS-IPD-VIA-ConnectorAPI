namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class Template
    {
        [JsonProperty("xsquareId", NullValueHandling = NullValueHandling.Ignore)]
        public string XsquareId { get; set; }

        [JsonProperty("xsquareTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public XsquareTemplate XsquareTemplate { get; set; }
    }
}
