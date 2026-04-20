namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
	using Newtonsoft.Json;
	using System.Collections.Generic;

	/// <summary>
	/// 
	/// </summary>
	public class RecordingSessionNotification
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("destinationMediaAssetRef", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationMediaAssetRef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
        public string Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("recorderRef", NullValueHandling = NullValueHandling.Ignore)]
        public string RecorderRef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("requestedIn", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(RequestedJsonConverter))]
        public Requested RequestedIn { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("requestedOut", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(RequestedJsonConverter))]
        public Requested RequestedOut { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sourceMediaAssetRef", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceMediaAssetRef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sourceRef", NullValueHandling = NullValueHandling.Ignore)]
        public object SourceRef { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<TargetRecording> Targets { get; set; }
    }
}
