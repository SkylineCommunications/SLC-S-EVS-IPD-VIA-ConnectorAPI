namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class TargetParametersTarget
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("xsquareId", NullValueHandling = NullValueHandling.Ignore)]
        public string XsquareId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("xsquareTargetId", NullValueHandling = NullValueHandling.Ignore)]
        public string XsquareTargetId { get; set; }
    }
}
