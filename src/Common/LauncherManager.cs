using Mugnum.FFmpegLauncher.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mugnum.FFmpegLauncher.Common
{
	/// <summary>
	/// FFmpeg launcher manager.
	/// </summary>
	internal class LauncherManager
	{
		#region Constants and fields

		/// <summary>
		/// Path to executable.
		/// </summary>
		private const string ExecutablePath = "ffmpeg";

		/// <summary>
		/// Path to console application.
		/// </summary>
		private const string ConsoleApplication = "cmd.exe";

		/// <summary>
		/// Is execution in progress.
		/// </summary>
		private bool _isQueueBusy;

		#endregion Constants and fields

		#region Properties and events

		/// <summary>
		/// Command queue.
		/// </summary>
		private Queue<Command> CommandsQueue { get; } = new Queue<Command>();

		/// <summary>
		/// Handler for command execution.
		/// </summary>
		public event EventHandler<CommandEventArgs> CommandExecuted;

		#endregion Properties and events

		#region Constructors

		/// <summary>
		/// Create FFmpeg launcher manager instance.
		/// </summary>
		public LauncherManager()
		{
			CommandExecuted += ProcessQueue;
		}

		#endregion Constructors

		#region Methods: Public

		/// <summary>
		/// Execute command.
		/// </summary>
		/// <param name="command"> Command. </param>
		/// <param name="isQueued"> Is processing in a queue. </param>
		/// <exception cref="ArgumentNullException"></exception>
		public void Execute(Command command, bool isQueued = false)
		{
			_ = command ?? throw new ArgumentNullException(nameof(command));

			if (isQueued && _isQueueBusy)
			{
				CommandsQueue.Enqueue(command);
				return;
			}

			_ = ExecuteCommand(command);
		}

		/// <summary>
		/// Clears command queue.
		/// </summary>
		public void ClearQueue()
		{
			CommandsQueue.Clear();
		}

		#endregion Methods: Public

		#region Methods: Private

		/// <summary>
		/// Processes next enqueued command.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="eventArgs"> Event arguments. </param>
		private void ProcessQueue(object sender, EventArgs eventArgs)
		{
			// TODO: At the moment, this may skip active queue item when mixing modes.

			if (CommandsQueue.Any())
			{
				_ = ExecuteCommand(CommandsQueue.Dequeue());
			}
		}

		/// <summary>
		/// Execute command.
		/// </summary>
		/// <param name="command"> Command. </param>
		/// <param name="isQueued"> Is processing in a queue. </param>
		/// <exception cref="ArgumentNullException"></exception>
		private async Task ExecuteCommand(Command command, bool isQueued = false)
		{
			_ = command ?? throw new ArgumentNullException(nameof(command));
			_isQueueBusy = true;

			var builder = new StringBuilder();
			var firstParams = command.FirstFileParameter?.Parameters?.ToLower().Trim() ?? string.Empty;
			var secondParams = command.SecondFileParameter?.Parameters?.ToLower().Trim() ?? string.Empty;
			var outputParams = command.OutputFileParameter?.Parameters?.ToLower().Trim() ?? string.Empty;
			var firstFilePath = command.FirstFileParameter?.FilePath?.Trim() ?? string.Empty;
			var secondFilePath = command.SecondFileParameter?.FilePath?.Trim() ?? string.Empty;
			var outputFilePath = command.OutputFileParameter?.FilePath?.Trim() ?? string.Empty;

			// Replace newlines with spaces.
			firstParams = Regex.Replace(firstParams, @"\r\n?|\n", " ");
			secondParams = Regex.Replace(secondParams, @"\r\n?|\n", " ");
			outputParams = Regex.Replace(outputParams, @"\r\n?|\n", " ");
			var noFfmpegMacro = $"{{{LauncherConstants.NoFfmpeg}}}";

			if (!firstParams.Contains(noFfmpegMacro)
				&& !secondParams.Contains(noFfmpegMacro)
				&& !outputParams.Contains(noFfmpegMacro))
			{
				builder.Append($" {ExecutablePath}");
			}

			builder.Append($" {firstParams}");

			if (!string.IsNullOrEmpty(firstFilePath)
				&& !firstParams.Contains($"{{{LauncherConstants.IgnoreInputFileArgument}}}"))
			{
				builder.Append($" -i \"{firstFilePath}\"");
			}

			builder.Append($" {secondParams}");

			if (!string.IsNullOrEmpty(secondFilePath)
			    && !secondParams.Contains($"{{{LauncherConstants.IgnoreInputFileArgument}}}"))
			{
				builder.Append($" -i \"{secondFilePath}\"");
			}

			builder.Append($" {outputParams}");
			var isSkippingOutputPathAutoAppend = string.IsNullOrEmpty(outputFilePath)
				|| outputParams.Contains($"{{{LauncherConstants.OutputFileName}}}");

			var cmdText = builder.ToString()
				.Replace($"{{{LauncherConstants.FirstFileName}}}", $"\"{firstFilePath}\"")
				.Replace($"{{{LauncherConstants.SecondFileName}}}", $"\"{secondFilePath}\"")
				.Replace($"{{{LauncherConstants.OutputFileName}}}", $"\"{outputFilePath}\"");

			var ignoredKeywords = new[]
			{
				LauncherConstants.NoFfmpeg,
				LauncherConstants.PreferredFormat,
				LauncherConstants.IgnoreInputFileArgument,
				LauncherConstants.FirstFileName,
				LauncherConstants.SecondFileName,
				LauncherConstants.OutputFileName
			};
			cmdText = FilterOutKeywords(cmdText, ignoredKeywords);

			if (!isSkippingOutputPathAutoAppend)
			{
				cmdText += $" \"{outputFilePath}\"";
			}

			// Close console on finish and continue queue processing.
			if (command.IsClosingOnFinish
				|| (isQueued && CommandsQueue.Any()))
			{
				cmdText += " & exit";
			}

			var process = Process.Start(ConsoleApplication, $"/k {cmdText}");
			await process.WaitForExitAsync();
			_isQueueBusy = CommandsQueue.Any();

			CommandExecuted?.Invoke(this, new CommandEventArgs(outputFilePath));
		}

		/// <summary>
		/// Filter out keywords inside curly brackets from text.
		/// For example: given "output" keyword, entire block "{output=path}" would be removed.
		/// </summary>
		/// <param name="text"> Initial text. </param>
		/// <param name="keywords"> Keywords to remove. </param>
		/// <returns> Filtered text. </returns>
		private static string FilterOutKeywords(string text, params string[] keywords)
		{
			if (string.IsNullOrEmpty(text)
				|| keywords == null || !keywords.Any())
			{
				return text;
			}

			return keywords.Aggregate(text, RemoveEntireMacro);
		}

		/// <summary>
		/// Removes entire macro, whether it contains value or not.
		/// </summary>
		/// <param name="initialText"> Initial text. </param>
		/// <param name="keyword"> Macro name. </param>
		/// <returns> Modified text. </returns>
		private static string RemoveEntireMacro(string initialText, string keyword)
		{
			if (string.IsNullOrEmpty(initialText) || string.IsNullOrEmpty(keyword))
			{
				return initialText;
			}

			var regexPattern = $@"(?=\{{{keyword})(.*?)(?<=\}})";
			return Regex.Replace(initialText, regexPattern, string.Empty);
		}

		#endregion Methods: Private
	}
}
