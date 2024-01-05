using System;
using System.Linq;
using System.Windows.Forms;

namespace Mugnum.FFmpegLauncher.Forms
{
	/// <summary>
	/// Form for editing a preset.
	/// </summary>
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
		/// Create instance of preset editing form.
		/// </summary>
		public EditPresetForm(bool isOverridingExistingPreset = false)
		{
			// TODO: Shouldn't pass config stuff via constructor, consider using singleton instead.

			InitializeComponent();
			OverrideExistingCheckbox.Checked = isOverridingExistingPreset;
		}

		/// <summary>
		/// Adds new preset.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void AddButton_Click(object sender, EventArgs e)
		{
			var presetName = PresetNameTextBox.Text?.Trim();

			if (string.IsNullOrEmpty(presetName))
			{
				PresetNameTextBox.Focus();
				return;
			}

			PresetName = presetName;

			if (!OverrideExistingCheckbox.Checked
				&& ExistingPresets != null && ExistingPresets.Any()
				&& ExistingPresets.Contains(presetName, StringComparer.InvariantCultureIgnoreCase))
			{
				var messageReply = MessageBox.Show(null, $"\"{presetName}\" already exists.\r\n" +
					"Would you like to override it?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (messageReply != DialogResult.No)
				{
					return;
				}
			}

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
