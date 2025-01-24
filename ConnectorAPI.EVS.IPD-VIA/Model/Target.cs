namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA.Model
{
    /// <summary>
    /// Represents a target from the Targets table.
    /// </summary>
	public class Target
    {
        /// <summary>
        /// Gets or sets the instance of the target.
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// Gets or sets the name of the target.
        /// </summary>
		public string Name { get; set; }
    }
}
