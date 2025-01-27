namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class Template
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("xsquareId", NullValueHandling = NullValueHandling.Ignore)]
        public string XsquareId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("xsquareTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public XsquareTemplate XsquareTemplate { get; set; }
    }
}
