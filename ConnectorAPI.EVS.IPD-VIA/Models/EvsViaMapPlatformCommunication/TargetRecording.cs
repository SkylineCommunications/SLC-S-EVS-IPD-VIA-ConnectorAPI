namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;

	/// <summary>
	/// 
	/// </summary>
	public class TargetRecording
	{
		/// <summary>
		/// 
		/// </summary>
		public TargetRecording()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		public TargetRecording(string key)
        {
            TargetRef = key;
        }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("targetParameters", NullValueHandling = NullValueHandling.Ignore)]
        public TargetParameters TargetParameters { get; set; } = new TargetParameters();

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("targetRef", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetRef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("workflowInstanceRef", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowInstanceRef { get; set; }
    }
}
