using System.Collections.Generic;

namespace Mugnum.FFmpegLauncher.Extensions
{
	/// <summary>
	/// Extension of <see cref="Queue{T}"/> class.
	/// </summary>
	internal static class QueueExtension
	{
		/// <summary>
		/// Check if queue is empty.
		/// </summary>
		/// <typeparam name="T"> Enumeration type. </typeparam>
		/// <param name="queue"> Queue instance. </param>
		/// <returns> <see langword="true"/> - if queue contains no elements. </returns>
		public static bool IsEmpty<T>(this Queue<T> queue)
		{
			return queue.Count == 0;
		}
	}
}
