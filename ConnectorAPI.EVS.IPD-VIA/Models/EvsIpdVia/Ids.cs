namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Ids
    {
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ListIds { get; set; }
    }
}
