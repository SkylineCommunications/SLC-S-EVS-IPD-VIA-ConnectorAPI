namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class Metadata
    {
        public Metadata(string[] metadataProfileFqns, Dictionary<string, object> values)
        {
            MetadataProfileFqns = metadataProfileFqns;
            Values = values;
        }

        [JsonProperty("contexts")]
        public string[] Contexts { get; set; } = new string[0];

        [JsonProperty("creationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreationDate { get; set; }

        [JsonProperty("metadataProfileFqns", NullValueHandling = NullValueHandling.Ignore)]
        public string[] MetadataProfileFqns { get; set; }

        [JsonProperty("modificationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ModificationDate { get; set; }

        [JsonProperty("origins", NullValueHandling = NullValueHandling.Ignore)]
        public Origins Origins { get; set; }

        [JsonProperty("_type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Values { get; set; }
    }
}
