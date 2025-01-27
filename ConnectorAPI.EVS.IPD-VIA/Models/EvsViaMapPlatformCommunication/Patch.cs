namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

	/// <summary>
	/// 
	/// </summary>
	public class Patch
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Updated { get; set; }
    }
}
