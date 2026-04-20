namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

	/// <summary>
	/// 
	/// </summary>
	public class Metadata
	{
		/// <summary>
		/// 
		/// </summary>
		public Metadata()
        {

        }

		/// <summary>
		/// 
		/// </summary>
		public Metadata(string[] metadataProfileFqns, Dictionary<string, object> values)
        {
            MetadataProfileFqns = metadataProfileFqns;
            Values = values;
        }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("contexts")]
        public string[] Contexts { get; set; } = new string[0];

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("creationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreationDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("metadataProfileFqns", NullValueHandling = NullValueHandling.Ignore)]
        public string[] MetadataProfileFqns { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("modificationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ModificationDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("_type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Values { get; set; }
    }
}
