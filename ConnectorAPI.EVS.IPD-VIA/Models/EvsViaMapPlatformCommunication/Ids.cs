namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

	/// <summary>
	/// 
	/// </summary>
	public class Ids
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ListIds { get; set; }
    }
}
