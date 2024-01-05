using Mugnum.FFmpegLauncher.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Mugnum.FFmpegLauncher
{
	/// <summary>
	/// FFmpeg launcher main program.
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.ThreadException += Application_ThreadException;
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

			Application.Run(new LauncherForm());
		}

		/// <summary>
		/// Display unhandled exception.
		/// </summary>
		/// <param name="sender"> Executing object. </param>
		/// <param name="e"> Exception event arguments. </param>
		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.ToString(), "An error has occured",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
