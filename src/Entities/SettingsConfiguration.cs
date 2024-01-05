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
		/// When set to <see langword="true"/> - copies first input file's name to output file's name.
		/// </summary>
		public bool IsCopyingFileName { get; set; }

		/// <summary>
		/// When set to <see langword="true"/> - closes console on finished execution.
		/// </summary>
		public bool IsClosingOnFinish { get; set; } = true;

		/// <summary>
		/// Overrides existing preset if preset with given name already exists.
		/// </summary>
		public bool IsOverridingExistingPreset { get; set; } = true;

		/// <summary>
		/// Last known "Presets" ComboBox index.
		/// </summary>
		public int LastSelectedPresetIndex { get; set; } = DefaultComboBoxIndex;

		/// <summary>
		/// Default path to files.
		/// </summary>
		public string DefaultPath { get; set; }

		/// <summary>
		/// Create new settings configuration instance.
		/// </summary>
		public SettingsConfiguration()
		{
			Presets = new List<Preset>();
		}
	}
}
