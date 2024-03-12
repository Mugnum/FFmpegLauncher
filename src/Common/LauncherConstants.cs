namespace Mugnum.FFmpegLauncher.Common
{
	/// <summary>
	/// FFmpeg launcher constants.
	/// </summary>
	internal static class LauncherConstants
	{
		/// <summary>
		/// Replacement for blank display values.
		/// </summary>
		public const string UnknownName = "---------";

		/// <summary>
		/// Macro for skipping running FFmpeg executable.
		/// </summary>
		public const string NoFfmpeg = "noffmpeg";

		/// <summary>
		/// Macro for storing first file's name.
		/// </summary>
		public const string FirstFileName = "file1name";

		/// <summary>
		/// Macro for storing second file's name.
		/// </summary>
		public const string SecondFileName = "file2name";

		/// <summary>
		/// Macro for storing output file's name.
		/// </summary>
		public const string OutputFileName = "outputname";

		/// <summary>
		/// Macro for skipping adding "-i" argument before paths to file.
		/// Can be used to retrieve file path using <see cref="FirstFileName"/> macro,
		/// without actually passing it to FFmpeg.
		/// </summary>
		public const string IgnoreInputFileArgument = "ignore_i";

		/// <summary>
		/// Macro for preferred output file extension.
		/// </summary>
		public const string PreferredFormat = "preferred_format";

		/// <summary>
		/// Default input file formats.
		/// </summary>
		public const string DefaultInputFileFormats = "Video files (MP4, etc.)|*.mp4; *.mkv; *.mov; *.avi; *.wmv; *.webm; *.m4v; *.gif|" +
			"Audio files (WAV, etc.)|*.wav; *.mp3; *.opus; *.m4a; *.ogg; *.flac; *.aac; *.alac; *.ape; *.webm|" +
			"Image files (PNG, etc.)|*.png; *.jpg; *.bmp; .tiff; *.jpeg; *.raw; *.gif|" +
			"All files (*.*)|*.*";

		/// <summary>
		/// Default output file formats.
		/// </summary>
		public const string DefaultOutputFileFormats = "MP4 file (*.mp4)|*.mp4|MKV file (*.mkv)|*.mkv|" +
			"PNG file (*.png)|*.png|All files (*.*)|*.*";
	}
}
