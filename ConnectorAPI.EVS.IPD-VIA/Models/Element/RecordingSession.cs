namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.Element
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents a recording session in the EVS IPD-VIA model.
	/// </summary>
	public class RecordingSession
	{
		/// <summary>
		/// Gets or sets the ID of the recording session.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the name of the recording session.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the start time of the recording session.
		/// </summary>
		public DateTime Start { get; set; }

		/// <summary>
		/// Gets or sets the end time of the recording session.
		/// </summary>
		public DateTime End { get; set; }

		/// <summary>
		/// Gets or sets the status of the recording session.
		/// </summary>
		public RecordingSessionStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the recorder associated with the recording session.
		/// </summary>
		public Recorder Recorder { get; set; }

		/// <summary>
		/// Gets or sets the list of targets associated with the recording session.
		/// </summary>
		public IEnumerable<Target> Targets { get; set; } = new List<Target>();

		/// <summary>
		/// Gets or sets the metadata associated with the recording session.
		/// </summary>
		public IEnumerable<Metadata> Metadata { get; set; } = new List<Metadata>();

		/// <summary>
		/// Gets the Hash code for the recording session.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			int hashCode = Id == null ? 1 : Id.GetHashCode();
			hashCode ^= Name == null ? 1 : Name.GetHashCode();
			hashCode ^= Start.GetHashCode();
			hashCode ^= End.GetHashCode();
			hashCode ^= Recorder == null ? 1 : Recorder.GetHashCode();
			hashCode ^= Status.GetHashCode();
			hashCode ^= Targets == null ? 1 : Targets.GetHashCode();
			hashCode ^= Metadata == null ? 1 : Metadata.GetHashCode();
			return hashCode;
		}

		/// <summary>
		/// Checks equality between current instance and given instance.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			if (obj == null) return false;

			if (ReferenceEquals(this, obj)) return true;

			if (!(obj is RecordingSession second)) return false;

			bool isEqual = true;

			isEqual &= Id == second.Id;
			isEqual &= Name == second.Name;
			isEqual &= Start == second.Start;
			isEqual &= End == second.End;
			isEqual &= Recorder?.Id == second.Recorder?.Id;
			isEqual &= Recorder?.Name == second.Recorder?.Name;
			isEqual &= Status == second.Status;

			return isEqual;
		}
	}
}