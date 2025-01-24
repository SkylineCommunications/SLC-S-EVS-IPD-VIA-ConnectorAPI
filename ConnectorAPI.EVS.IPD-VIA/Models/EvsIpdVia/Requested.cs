namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdVia
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;

    public class Requested
    {
        // HTTP communication with EVS platform should always be in local datetimes.
        // RabbitMQ communication with EVS platform is always in UTC datetimes.

        [JsonConstructor]
        public Requested(string date, string time) // This constructor is used to deserialize HTTP responses, datetimes should be Local
        {
            Date = date ?? throw new ArgumentNullException(nameof(date));
            Time = time ?? throw new ArgumentNullException(nameof(time));

            string trimmedTime = Time.Trim('.', ' ');
            if (!TimeSpan.TryParseExact(trimmedTime, "hh':'mm':'ss':'ff", CultureInfo.InvariantCulture, out var timeSpan))
            {
                throw new ArgumentException($"Unable to parse '{trimmedTime}' to a timespan", nameof(time));
            }

            if (!DateTime.TryParse(Date, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var dateTime))
            {
                throw new ArgumentException($"Unable to parse '{Date}' to a DateTime", nameof(date));
            }

            DateTime = dateTime.Add(timeSpan);
        }

        public Requested(DateTime dateTime)
        {
            // This constructor is used to create HTTP requests, where datetimes should be Local
            // OR to deserialize RabbitMQ messages, where datetimes should be UTC

            if (dateTime.Kind == DateTimeKind.Unspecified) throw new ArgumentException("Unspecified datetime kind", nameof(dateTime));

            DateTime = dateTime;
            Date = DateTime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            Time = DateTime.ToString("HH:mm:ss:ff", CultureInfo.InvariantCulture);
        }

        [JsonProperty("date")]
        public string Date { get; }

        [JsonIgnore]
        public DateTime DateTime { get; }

        [JsonProperty("time")]
        public string Time { get; }
    }
}
