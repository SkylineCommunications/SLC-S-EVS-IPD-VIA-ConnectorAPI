namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class Destination
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("iconId", NullValueHandling = NullValueHandling.Ignore)]
        public string IconId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }
    }
}
