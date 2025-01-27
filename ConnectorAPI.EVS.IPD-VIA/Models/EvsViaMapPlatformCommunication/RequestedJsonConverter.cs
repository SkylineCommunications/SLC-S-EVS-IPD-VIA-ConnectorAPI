namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;

	/// <summary>
	/// 
	/// </summary>
	public class RequestedJsonConverter : JsonConverter
	{
		/// <summary>
		/// 
		/// </summary>
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Requested);
		}

		/// <summary>
		/// 
		/// </summary>
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.StartObject)
			{
				//format
				//{"date":"2024-09-18","time":"13:35:00:00"}

				JObject rawObject = JObject.Load(reader);
				return rawObject.ToObject<Requested>();
			}
			else
			{
				//format
				//"2024-09-18T10:35:00.120Z"

				string sDateTime = Convert.ToString(reader.Value);
				DateTime.TryParse(sDateTime, out DateTime dateTime);
				return new Requested(DateTime.SpecifyKind(dateTime, DateTimeKind.Utc));
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			JObject token = (JObject)JToken.FromObject(value);
			token.WriteTo(writer);
		}
	}
}
