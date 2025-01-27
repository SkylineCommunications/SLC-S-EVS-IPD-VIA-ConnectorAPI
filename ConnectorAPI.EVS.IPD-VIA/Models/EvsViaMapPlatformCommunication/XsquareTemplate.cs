namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class XsquareTemplate
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("destinations", NullValueHandling = NullValueHandling.Ignore)]
        public Destination[] Destinations { get; set; }
    }
}
