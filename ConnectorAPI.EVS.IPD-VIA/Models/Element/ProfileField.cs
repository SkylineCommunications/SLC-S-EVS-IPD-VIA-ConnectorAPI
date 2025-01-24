namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Models.Element
{
	/// <summary>
	/// Represents a profile field in the EVS IPD-VIA model.
	/// </summary>
	public class ProfileField
	{
		/// <summary>
		/// Gets or sets the instance of the profile field.
		/// </summary>
		public string Instance { get; set; }

		/// <summary>
		/// Gets or sets the key of the profile field.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Gets or sets the fully qualified name of the profile associated with the profile field.
		/// </summary>
		public string ProfileFullyQualifiedName { get; set; }

		/// <summary>
		/// Gets or sets the profile name associated with the profile field.
		/// </summary>
		public string ProfileName { get; set; }

		/// <summary>
		/// Gets or sets the name of the profile field.
		/// </summary>
		public string Label { get; set; }

		/// <summary>
		/// Gets or sets the type of the profile field.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the profile field is required.
		/// </summary>
		public bool Required { get; set; }
	}
}
