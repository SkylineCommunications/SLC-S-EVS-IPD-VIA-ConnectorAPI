namespace Skyline.DataMiner.ConnectorAPI.EVS.IPD_VIA
{
	using System;
	using System.ComponentModel;
	using System.Linq;

	/// <summary>
	/// A extension class for enums.
	/// </summary>
	public static class EnumExtensions
	{
		/// <summary>
		/// Gets the value of the <see cref="DescriptionAttribute"/> on the enum value if any. Otherwise it returns the enum value as string.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetDescription(this Enum value)
		{
			var attribute = value.GetType().GetField(value.ToString())
				.GetCustomAttributes(typeof(DescriptionAttribute), false)
				.SingleOrDefault() as DescriptionAttribute;

			return attribute is null
				? value.ToString()
				: attribute.Description;
		}
	}
}
