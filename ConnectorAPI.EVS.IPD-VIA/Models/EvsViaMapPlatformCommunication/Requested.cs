namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.EvsIpdViaPlatformCommunication
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;

	/// <summary>
	/// Represents *RequestdIn* and *RequestedOut* properties of the EVS IPD-VIA model.
	/// </summary>
	/// <remarks>
	/// HTTP communication with EVS platform should always be in local datetimes.
	/// RabbitMQ communication with EVS platform is always in UTC datetimes.
	/// </remarks>
	public class Requested
    {
		// HTTP communication with EVS platform should always be in local datetimes.
		// RabbitMQ communication with EVS platform is always in UTC datetimes.

		/// <summary>
		/// Initializes new instance of <seealso cref="Requested"/> class.
		/// </summary>
		/// <param name="date">Date part of the <seealso cref="DateTime"/> object.</param>
		/// <param name="time">Time part of the <seealso cref="DateTime"/> object.</param>
		/// <exception cref="ArgumentNullException">Throws if, either <paramref name="date"/> or <paramref name="time"/>, is null.</exception>
		/// <exception cref="ArgumentException">Throws if unable to parse <paramref name="date"/> as <seealso cref="System.DateTime"/> or <paramref name="time"/> as <seealso cref="TimeSpan"/></exception>
		/// <remarks>
		/// This constructor is used to deserialize HTTP responses, datetimes should be Local.
		/// </remarks>
		[JsonConstructor]
        public Requested(string date, string time)
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
			Frame = timeSpan.Milliseconds;
        }

		/// <summary>
		/// Initializes new instance of <seealso cref="Requested"/> class.
		/// </summary>
		/// <param name="dateTime">Date to be stored in <seealso cref="DateTime"/> property.</param>
		/// <param name="frame">Precise frame of the request.</param>
		/// <exception cref="ArgumentException">Throws if <paramref name="dateTime"/> has <seealso cref="DateTimeKind.Unspecified"/>.</exception>
		/// <remarks>
		/// This constructor is used to create HTTP requests, where datetimes should be Local OR to deserialize RabbitMQ messages, where datetimes should be UTC.
		/// EVS expects precise frame to be sent as ms component of the <seealso cref="Time"/>.
		/// </remarks>
		public Requested(DateTime dateTime, int frame = 0)
        {
            if (dateTime.Kind == DateTimeKind.Unspecified) throw new ArgumentException("Unspecified datetime kind", nameof(dateTime));

			DateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, frame, dateTime.Kind);
            Date = DateTime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            Time = DateTime.ToString("HH:mm:ss:ff", CultureInfo.InvariantCulture);
			Frame = frame;
		}

		/// <summary>
		/// Date of the request.
		/// </summary>
		[JsonProperty("date")]
        public string Date { get; }

		/// <summary>
		/// Date and time of the request.
		/// </summary>
		[JsonIgnore]
        public DateTime DateTime { get; }

		/// <summary>
		/// Time of the request.
		/// </summary>
		[JsonProperty("time")]
        public string Time { get; }

		/// <summary>
		/// Precise frame of the request.
		/// </summary>
		[JsonIgnore]
		public int Frame { get; }
    }
}
