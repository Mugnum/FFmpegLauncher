using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Mugnum.FFmpegLauncher.Common
{
	/// <summary>
	/// Extensions for <see cref="Process"/> class.
	/// </summary>
	internal static class ProcessExtension
	{
		/// <summary>
		/// Wait for process to exit asyncronously.
		/// </summary>
		/// <param name="process"> Process. </param>
		/// <param name="cancellationToken"> Cancellation token. </param>
		/// <returns> Execution result. </returns>
		public static Task WaitForExitAsync(this Process process, CancellationToken cancellationToken = default)
		{
			if (process == null || process.HasExited)
			{
				return Task.CompletedTask;
			}

			var completionSource = new TaskCompletionSource<object>();
			process.EnableRaisingEvents = true;
			process.Exited += (sender, args) => completionSource.TrySetResult(null);

			if (cancellationToken != default)
			{
				cancellationToken.Register(() => completionSource.SetCanceled());
			}

			return process.HasExited
				? Task.CompletedTask
				: completionSource.Task;
		}
	}
}
