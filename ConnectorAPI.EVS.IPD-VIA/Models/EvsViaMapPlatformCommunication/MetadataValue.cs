namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class MetadataValue
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type_", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("jsonValue_", NullValueHandling = NullValueHandling.Ignore)]
        public string JsonValue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("label_", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }
    }
}
