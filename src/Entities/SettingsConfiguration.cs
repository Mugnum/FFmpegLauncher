using System.Collections.Generic;

namespace Mugnum.FFmpegLauncher.Entities
{
	/// <summary>
	/// Settings configuration.
	/// </summary>
	internal class SettingsConfiguration
	{
		/// <summary>
		/// Default index of <see cref="System.Windows.Forms.ComboBox"/>.
		/// </summary>
		private const int DefaultComboBoxIndex = -1;

		/// <summary>
		/// Presets.
		/// </summary>
		private List<Preset> _presets;

		/// <summary>
		/// Presets.
		/// </summary>
		public List<Preset> Presets
		{
			get => _presets;
			set => _presets = value ?? new List<Preset>();
		}

		/// <summary>
		/// Need to copy first input file's name to output file's path.
		/// </summary>
		public bool IsCopyingFileName { get; set; }

		/// <summary>
		/// Need to close console on finished execution.
		/// </summary>
		public bool IsClosingOnFinish { get; set; } = true;

		/// <summary>
		/// Overrides existing preset if preset with given name already exists.
		/// </summary>
		public bool IsOverridingExistingPreset { get; set; } = false;

		/// <summary>
		/// Last known "Presets" ComboBox index.
		/// </summary>
		public int LastSelectedPresetIndex { get; set; } = DefaultComboBoxIndex;

		/// <summary>
		/// Path to FFmpeg executable.
		/// </summary>
		public string FfmpegExePath { get; set; }

		/// <summary>
		/// Default path to files.
		/// </summary>
		public string DefaultPath { get; set; }

		/// <summary>
		/// Start FFmpeg minimized, without stealing focus.
		/// </summary>
		public bool StartFfmpegMinimized { get; set; }

		/// <summary>
		/// Create new settings configuration instance.
		/// </summary>
		public SettingsConfiguration()
		{
			Presets = new List<Preset>();
		}
	}
}
