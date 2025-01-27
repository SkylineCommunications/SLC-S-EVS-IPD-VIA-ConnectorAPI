namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class MetadataOrigin
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("isInherited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInherited { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("resourceRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceRef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("resourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }
    }
}
