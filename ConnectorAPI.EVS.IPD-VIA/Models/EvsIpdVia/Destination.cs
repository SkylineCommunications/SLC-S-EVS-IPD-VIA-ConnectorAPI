namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class Destination
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("iconId", NullValueHandling = NullValueHandling.Ignore)]
        public string IconId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }
    }
}
