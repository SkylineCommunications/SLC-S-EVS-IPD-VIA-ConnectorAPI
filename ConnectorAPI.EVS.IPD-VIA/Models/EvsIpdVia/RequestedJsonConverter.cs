namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
	using System;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;

	public class RequestedJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Requested);
		}

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

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			JObject token = (JObject)JToken.FromObject(value);
			token.WriteTo(writer);
		}
	}
}
