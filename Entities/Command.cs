using System;

namespace Mugnum.FFmpegLauncher.Entities
{
	/// <summary>
	/// FFmpeg execution command.
	/// </summary>
	internal class Command
	{
		/// <summary>
		/// First input file's parameter set.
		/// </summary>
		private InputFileParameter _firstFileParameter;

		/// <summary>
		/// Second input file's parameter set.
		/// </summary>
		private InputFileParameter _secondFileParameter;

		/// <summary>
		/// Output file's parameter set.
		/// </summary>
		private OutputFileParameter _outputFileParameter;

		/// <summary>
		/// First input file's parameter set.
		/// </summary>
		public InputFileParameter FirstFileParameter
		{
			get => _firstFileParameter;
			set => _firstFileParameter = value ?? new InputFileParameter();
		}

		/// <summary>
		/// Second input file's parameter set.
		/// </summary>
		public InputFileParameter SecondFileParameter
		{
			get => _secondFileParameter;
			set => _secondFileParameter = value ?? new InputFileParameter();
		}

		/// <summary>
		/// Output file's parameter set.
		/// </summary>
		public OutputFileParameter OutputFileParameter
		{
			get => _outputFileParameter;
			set => _outputFileParameter = value ?? new OutputFileParameter();
		}

		/// <summary>
		/// Close console upon finishing the processing.
		/// </summary>
		public bool IsClosingOnFinish { get; set; }

		/// <summary>
		/// Create FFmpeg execution command instance.
		/// </summary>
		public Command()
		{
			FirstFileParameter = new InputFileParameter();
			SecondFileParameter = new InputFileParameter();
			OutputFileParameter = new OutputFileParameter();
		}

		/// <summary>
		/// Create FFmpeg execution command instance.
		/// </summary>
		/// <param name="firstFileParameter"> First input file parameter set. </param>
		/// <param name="secondFileParameter"> Second input file parameter set. </param>
		/// <param name="outputFileParameter"> Output file parameter set. </param>
		/// <param name="isClosingOnFinish"> Close console upon finishing the processing. </param>
		/// <exception cref="ArgumentNullException"></exception>
		public Command(InputFileParameter firstFileParameter, InputFileParameter secondFileParameter,
			OutputFileParameter outputFileParameter, bool isClosingOnFinish = false)
		{
			FirstFileParameter = firstFileParameter;
			SecondFileParameter = secondFileParameter;
			OutputFileParameter = outputFileParameter;
			IsClosingOnFinish = isClosingOnFinish;
		}

		/// <summary>
		/// Create FFmpeg execution command instance.
		/// </summary>
		/// <param name="firstFileParam"> First input file's execution parameters. </param>
		/// <param name="firstFilePath"> Path to first input file. </param>
		/// <param name="secondFileParam"> Second input file's execution parameters. </param>
		/// <param name="secondFilePath"> Path to second input file. </param>
		/// <param name="outputParam"> Output file execution parameters. </param>
		/// <param name="outputFilePath"> Path to output file. </param>
		/// <param name="isClosingOnFinish"> Close console upon finishing the processing. </param>
		public Command(string firstFileParam, string firstFilePath, string secondFileParam,
			string secondFilePath, string outputParam, string outputFilePath, bool isClosingOnFinish = false)
		{
			FirstFileParameter = new InputFileParameter
			{
				FilePath = firstFilePath,
				Parameters = firstFileParam
			};
			SecondFileParameter = new InputFileParameter
			{
				FilePath = secondFilePath,
				Parameters = secondFileParam
			};
			OutputFileParameter = new OutputFileParameter
			{
				FilePath = outputFilePath,
				Parameters = outputParam
			};
			IsClosingOnFinish = isClosingOnFinish;
		}
	}
}
