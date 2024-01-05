using Mugnum.FFmpegLauncher.Common;
using System;

namespace Mugnum.FFmpegLauncher.Entities
{
	/// <summary>
	/// FFmpeg preset.
	/// </summary>
	internal class Preset : Command
	{
		/// <summary>
		/// Preset name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Create FFmpeg preset instance.
		/// </summary>
		public Preset()
		{
		}

		/// <summary>
		/// Create FFmpeg preset instance.
		/// </summary>
		/// <param name="presetName"> Preset name. </param>
		public Preset(string presetName)
		{
			Name = presetName;
		}

		/// <summary>
		/// Create FFmpeg preset instance.
		/// </summary>
		/// <param name="presetName"> Preset name. </param>
		/// <param name="firstFileParameter"> First input file parameter set. </param>
		/// <param name="secondFileParameter"> Second input file parameter set. </param>
		/// <param name="outputFileParameter"> Output file parameter set. </param>
		/// <param name="isClosingOnFinish"> Close console upon finishing the processing. </param>
		/// <exception cref="ArgumentNullException"></exception>
		public Preset(string presetName, InputFileParameter firstFileParameter, InputFileParameter secondFileParameter,
				OutputFileParameter outputFileParameter, bool isClosingOnFinish = false)
			: base(firstFileParameter, secondFileParameter, outputFileParameter, isClosingOnFinish)
		{
			Name = presetName;
			firstFileParameter = firstFileParameter ?? new InputFileParameter();
			secondFileParameter = secondFileParameter ?? new InputFileParameter();
			outputFileParameter = outputFileParameter ?? new OutputFileParameter();
			firstFileParameter.FilePath = null;
			secondFileParameter.FilePath = null;
			outputFileParameter.FilePath = null;
		}

		/// <summary>
		/// Create FFmpeg preset instance.
		/// </summary>
		/// <param name="presetName"> Preset name. </param>
		/// <param name="firstFileParam"> First input file's execution parameters. </param>
		/// <param name="secondFileParam"> Second input file's execution parameters. </param>
		/// <param name="outputParam"> Output file execution parameters. </param>
		/// <param name="isClosingOnFinish"> Close console upon finishing the processing. </param>
		public Preset(string presetName, string firstFileParam, string secondFileParam,
				string outputParam, bool isClosingOnFinish = false)
			: base(firstFileParam, string.Empty, secondFileParam, string.Empty,
				outputParam, string.Empty, isClosingOnFinish)
		{
			Name = presetName;
		}

		/// <summary>
		/// Returns string representation of preset.
		/// </summary>
		/// <returns> Preset name. </returns>
		public override string ToString()
		{
			return string.IsNullOrEmpty(Name)
				? LauncherConstants.UnknownName
				: Name;
		}
	}
}
