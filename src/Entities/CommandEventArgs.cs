using System;

namespace Mugnum.FFmpegLauncher.Entities
{
	/// <summary>
	/// Arguments for <see cref="Command"/> related events.
	/// </summary>
	internal class CommandEventArgs : EventArgs
	{
		/// <summary>
		/// Path to output file.
		/// </summary>
		public string OutputFileName { get; set; }

		/// <summary>
		/// Create instance of <see cref="Command"/> related event arguments.
		/// </summary>
		/// <param name="outputFileName"> Path to output file. </param>
		public CommandEventArgs(string outputFileName = "")
		{
			OutputFileName = outputFileName;
		}
	}
}
