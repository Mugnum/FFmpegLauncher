using System.Collections.Generic;

namespace Mugnum.FFmpegLauncher.Extensions
{
	/// <summary>
	/// Extension for <see cref="List{T}"/> class.
	/// </summary>
	internal static class ListExtension
	{
		/// <summary>
		/// Check if list is empty.
		/// </summary>
		/// <typeparam name="T"> Enumeration type. </typeparam>
		/// <param name="list"> List instance. </param>
		/// <returns> <see langword="true"/> - if list contains no elements. </returns>
		public static bool IsEmpty<T>(this List<T> list)
		{
			return list.Count == 0;
		}

		/// <summary>
		/// Check if list is null or empty.
		/// </summary>
		/// <typeparam name="T"> Enumeration type. </typeparam>
		/// <param name="list"> List instance. </param>
		/// <returns> <see langword="true"/> - if list contains no elements or is null. </returns>
		public static bool IsNullOrEmpty<T>(this List<T> list)
		{
			return list == null || list.Count == 0;
		}
	}
}
