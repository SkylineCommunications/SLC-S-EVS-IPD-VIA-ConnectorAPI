namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;

    public class TargetRecording
    {
        public TargetRecording(string key)
        {
            TargetRef = key;
        }

        [JsonProperty("targetParameters", NullValueHandling = NullValueHandling.Ignore)]
        public TargetParameters TargetParameters { get; set; } = new TargetParameters();

        [JsonProperty("targetRef", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetRef { get; set; }

        [JsonProperty("workflowInstanceRef", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowInstanceRef { get; set; }
    }
}
