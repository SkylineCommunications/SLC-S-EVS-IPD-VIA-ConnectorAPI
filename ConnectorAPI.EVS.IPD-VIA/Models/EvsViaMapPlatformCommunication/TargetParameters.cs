namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class TargetParameters
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("storageRefs", NullValueHandling = NullValueHandling.Ignore)]
        public string[] StorageRefs { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("lowresStorageRefs", NullValueHandling = NullValueHandling.Ignore)]
        public LowresStorageRefs LowresStorageRefs { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("protect", NullValueHandling = NullValueHandling.Ignore)]
        public Protect Protect { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public TargetParametersTarget Target { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("browseAgent", NullValueHandling = NullValueHandling.Ignore)]
        public string BrowseAgent { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public Template Template { get; set; }
    }
}
