using Mugnum.FFmpegLauncher.Entities;
using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Mugnum.FFmpegLauncher.Forms
{
	/// <summary>
	/// Settings form.
	/// </summary>
	[System.Runtime.Versioning.SupportedOSPlatform("windows")]
	internal partial class SettingsForm : Form
	{
		/// <summary>
		/// Configuration containing various preferences.
		/// </summary>
		public SettingsConfiguration Configuration { get; }

		/// <summary>
		/// Create settings form instance.
		/// </summary>
		/// <param name="configuration"> Current settings configuration. </param>
		public SettingsForm(SettingsConfiguration configuration)
		{
			InitializeComponent();
			Configuration = configuration ?? new SettingsConfiguration();
			FillConfigurationFields();
		}

		#region Methods: Private

		/// <summary>
		/// Fills in form fields from provided configuration.
		/// </summary>
		private void FillConfigurationFields()
		{
			FfmpegExePathTextBox.Text = Configuration.FfmpegExePath;
			DefaultDirectoryTextBox.Text = Configuration.DefaultPath;
			StartFfmpegMinimizedCheckBox.Checked = Configuration.StartFfmpegMinimized;
		}

		/// <summary>
		/// Opens browse file/folder dialog.
		/// </summary>
		/// <param name="title"> Dialog title. </param>
		/// <param name="isFolderPicker"> If <see langword="true"/> - select folder, otherwise select file. </param>
		/// <param name="selectedPath"> Selected path. </param>
		/// <returns> Is file/folder successfully selected. </returns>
		private static bool BrowsePath(string title, bool isFolderPicker, out string selectedPath)
		{
			selectedPath = null;

			using var selectFolderDialog = new CommonOpenFileDialog();
			selectFolderDialog.Title = title;
			selectFolderDialog.Multiselect = false;
			selectFolderDialog.IsFolderPicker = isFolderPicker;

			if (selectFolderDialog.ShowDialog() != CommonFileDialogResult.Ok)
			{
				return false;
			}

			selectedPath = selectFolderDialog.FileName;
			return true;
		}

		#endregion Methods: Private

		#region Methods: Event handlers

		/// <summary>
		/// Saves current settings.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void SaveButton_Click(object sender, EventArgs e)
		{
			Configuration.FfmpegExePath = FfmpegExePathTextBox.Text;
			Configuration.DefaultPath = DefaultDirectoryTextBox.Text;
			Configuration.StartFfmpegMinimized = StartFfmpegMinimizedCheckBox.Checked;
		}

		/// <summary>
		/// On mouse hover over "FFmpeg exe" textbox.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void FfmpegExePathTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip.Show("If empty - will use launcher's current directory.", FfmpegExePathTextBox);
		}

		/// <summary>
		/// On mouse hover over "Default path" textbox.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void DefaultDirectoryTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip.Show("Default path for input and output files when starting launcher.", DefaultDirectoryTextBox);
		}

		/// <summary>
		/// On mouse hover over "Start FFmpeg minimized" checkbox.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void StartFfmpegMinimizedCheckBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip.Show("Start minimized, without stealing focus.", StartFfmpegMinimizedCheckBox);
		}

		/// <summary>
		/// Shows "Browse FFmpeg exe" dialog.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void BrowseFfmpegExePathButton_Click(object sender, EventArgs e)
		{
			if (BrowsePath("Browse FFmpeg exe", false, out var selectedPath))
			{
				FfmpegExePathTextBox.Text = selectedPath;
			}
		}

		/// <summary>
		/// Shows "Browse default path" dialog.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void BrowseDefaultDirectoryButton_Click(object sender, EventArgs e)
		{
			if (BrowsePath("Browse default directory", true, out var selectedPath))
			{
				DefaultDirectoryTextBox.Text = $"{selectedPath}\\";
			}
		}

		#endregion Methods: Event handlers
	}
}
