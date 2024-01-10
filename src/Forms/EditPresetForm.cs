using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace Mugnum.FFmpegLauncher.Forms
{
	/// <summary>
	/// Form for editing a preset.
	/// </summary>
	[SupportedOSPlatform("windows")]
	public partial class EditPresetForm : Form
	{
		/// <summary>
		/// Preset name.
		/// </summary>
		public string PresetName { get; private set; }

		/// <summary>
		/// Existing presets.
		/// </summary>
		public string[] ExistingPresets { get; set; }

		/// <summary>
		/// Automatically override existing preset.
		/// </summary>
		public bool IsOverridingExistingPreset { get; set; }

		/// <summary>
		/// Create instance of preset editing form.
		/// </summary>
		public EditPresetForm()
		{
			InitializeComponent();
			OverrideExistingCheckbox.Checked = IsOverridingExistingPreset;
		}

		/// <summary>
		/// Adds new preset.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void AddButton_Click(object sender, EventArgs e)
		{
			var presetName = PresetNameTextBox.Text.Trim();

			if (string.IsNullOrEmpty(presetName))
			{
				PresetNameTextBox.Focus();
				return;
			}

			PresetName = presetName;

			if (!IsOverridingExistingPreset
				&& ExistingPresets != null && ExistingPresets.Length > 0
				&& ExistingPresets.Contains(presetName, StringComparer.InvariantCultureIgnoreCase))
			{
				var messageReply = MessageBox.Show(null, $"\"{presetName}\" already exists.\r\n" +
					"Would you like to override it?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (messageReply != DialogResult.No)
				{
					PresetName = null;
					return;
				}
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		/// <summary>
		/// Processes toggling "Override" checkbox.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Arguments. </param>
		private void OverrideExistingCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			IsOverridingExistingPreset = OverrideExistingCheckbox.Checked;
		}
	}
}
