namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Patch
    {
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Updated { get; set; }
    }
}
