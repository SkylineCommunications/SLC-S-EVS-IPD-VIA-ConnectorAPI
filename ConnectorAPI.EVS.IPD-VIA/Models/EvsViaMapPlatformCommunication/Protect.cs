namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class Protect
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("hasValue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasValue { get; set; }
    }
}
