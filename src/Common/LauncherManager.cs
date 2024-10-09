using Mugnum.FFmpegLauncher.Entities;
using Mugnum.FFmpegLauncher.Extensions;
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
	internal partial class LauncherManager
	{
		#region Constants

		/// <summary>
		/// Default path to FFmpeg executable.
		/// </summary>
		private const string DefaultExecutablePath = "ffmpeg.exe";

		/// <summary>
		/// Path to console application.
		/// </summary>
		private const string ConsoleApplication = "cmd.exe";

		#endregion Constants

		#region Fields

		/// <summary>
		/// Is execution in progress.
		/// </summary>
		private bool _isQueueBusy;

		/// <summary>
		/// Path to FFmpeg executable.
		/// </summary>
		private string _executablePath;

		/// <summary>
		/// Start FFmpeg minimized.
		/// </summary>
		private bool _isStartingMinimized;

		#endregion Fields

		#region Properties and events

		/// <summary>
		/// New line detection regex pattern.
		/// </summary>
		/// <returns> Regex pattern for new line. </returns>
		[GeneratedRegex(@"\r\n?|\n")]
		private static partial Regex NewLineRegex();

		/// <summary>
		/// Command queue.
		/// </summary>
		private Queue<Command> CommandsQueue { get; } = new ();

		/// <summary>
		/// Handler for command execution.
		/// </summary>
		public event EventHandler<CommandEventArgs> CommandExecuted;

		/// <summary>
		/// Path to FFmpeg executable.
		/// </summary>
		private string ExecutablePath
		{
			get => _executablePath;
			set => _executablePath = string.IsNullOrEmpty(value)
				? DefaultExecutablePath
				: value;
		}

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
		/// <param name="isStartingMinimized"> Start FFmpeg minimized, without stealing focus. </param>
		/// <param name="executablePath"> Path to FFmpeg executable. If empty - launcher's current directory will be used. </param>
		/// <param name="isQueued"> Is processing in a queue. </param>
		/// <exception cref="ArgumentNullException"></exception>
		public void Execute(Command command, bool isStartingMinimized = false,
			string executablePath = DefaultExecutablePath, bool isQueued = false)
		{
			_ = command ?? throw new ArgumentNullException(nameof(command));
			_isStartingMinimized = isStartingMinimized;
			ExecutablePath = executablePath;

			if (isQueued && _isQueueBusy)
			{
				CommandsQueue.Enqueue(command);
				return;
			}

			_ = ExecuteCommand(command, isQueued);
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
		private void ProcessQueue(object sender, CommandEventArgs eventArgs)
		{
			if (!CommandsQueue.IsEmpty())
			{
				_ = ExecuteCommand(CommandsQueue.Dequeue(), true);
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
			const string ExecuteCommandsArgument = "/k";
			const string NoFfmpegMacro = $"{{{LauncherConstants.NoFfmpeg}}}";

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
			firstParams = NewLineRegex().Replace(firstParams, " ");
			secondParams = NewLineRegex().Replace(secondParams, " ");
			outputParams = NewLineRegex().Replace(outputParams, " ");

			if (!firstParams.Contains(NoFfmpegMacro)
				&& !secondParams.Contains(NoFfmpegMacro)
				&& !outputParams.Contains(NoFfmpegMacro))
			{
				builder.Append($" \"{ExecutablePath}\"");
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
				|| outputParams.Contains($"{{{LauncherConstants.OutputFileName}}}")
				|| outputParams.Contains($"{{{LauncherConstants.IgnoreOutputFileArgument}}}");

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
				LauncherConstants.OutputFileName,
				LauncherConstants.IgnoreOutputFileArgument
			};
			cmdText = FilterOutKeywords(cmdText, ignoredKeywords);

			if (!isSkippingOutputPathAutoAppend)
			{
				cmdText += $" \"{outputFilePath}\"";
			}

			// Close console on finish and continue queue processing.
			if (command.IsClosingOnFinish || isQueued)
			{
				cmdText += " & exit";
			}

			var process = new Process();
			process.StartInfo.FileName = ConsoleApplication;
			process.StartInfo.Arguments = $"{ExecuteCommandsArgument} \"{cmdText}\"";
			process.StartInfo.WindowStyle = _isStartingMinimized
				? ProcessWindowStyle.Minimized
				: ProcessWindowStyle.Normal;
			
			process.Start();
			await process.WaitForExitAsync();

			_isQueueBusy = !CommandsQueue.IsEmpty();
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
				|| keywords == null || keywords.Length == 0)
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
