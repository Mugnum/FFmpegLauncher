using Microsoft.WindowsAPICodePack.Dialogs;
using Mugnum.FFmpegLauncher.Common;
using Mugnum.FFmpegLauncher.Entities;
using Mugnum.FFmpegLauncher.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Windows.Forms;

namespace Mugnum.FFmpegLauncher.Forms
{
	/// <summary>
	/// FFmpeg launcher form.
	/// </summary>
	[SupportedOSPlatform("windows")]
	public partial class LauncherForm : Form
	{
		// TODO: Add drag-and-drop for files.
		// TODO: Add macros in GUI.

		#region Constants and fields

		/// <summary>
		/// Minimal <see cref="ComboBox"/> index value.
		/// </summary>
		private const int ComboBoxMinValue = 0;

		/// <summary>
		/// Default text for "Preset" label.
		/// </summary>
		private const string DefaultPresetLabelText = "Preset:";

		/// <summary>
		/// Config file name.
		/// </summary>
		private readonly string _configFileName;

		/// <summary>
		/// Backup config file name.
		/// </summary>
		private readonly string _backupConfigFileName;

		/// <summary>
		/// FFmpeg launcher manager.
		/// </summary>
		private readonly LauncherManager _launcherManager = new();

		/// <summary>
		/// Settings configuration.
		/// </summary>
		private readonly SettingsConfiguration _config;

		/// <summary>
		/// Current preset.
		/// </summary>
		private Preset _currentPreset;

		#endregion Constants and fields

		#region Constructors

		/// <summary>
		/// Create FFmpeg launcher form instance.
		/// </summary>
		public LauncherForm()
		{
			InitializeComponent();

			var executableName = Assembly.GetExecutingAssembly().GetName().Name;
			_configFileName = $"{executableName}.json";
			_backupConfigFileName = $"{executableName}_backup.json";

			// Read config from file.
			try
			{
				var configJson = File.ReadAllText(_configFileName);
				_config = JsonSerializer.Deserialize<SettingsConfiguration>(configJson);
			}
			catch (Exception)
			{
				_config = new SettingsConfiguration();
			}

			InitializeConfig();

			Application.ApplicationExit += OnApplicationExit;
			_launcherManager.CommandExecuted += RemoveQueuedItem;

			FirstInputParamTextBox.TextChanged += ChangeLabelForPreset;
			FirstFilePathTextBox.TextChanged += ChangeLabelForPreset;
			SecondInputParamTextBox.TextChanged += ChangeLabelForPreset;
			SecondFilePathTextBox.TextChanged += ChangeLabelForPreset;
			OutputParameterTextBox.TextChanged += ChangeLabelForPreset;
			OutputFilePathTextBox.TextChanged += ChangeLabelForPreset;
		}

		#endregion Constructors

		#region Methods: Protected

		/// <summary>
		/// Processes a command key.
		/// </summary>
		/// <param name="msg"> A <see cref="Message"/>, passed by reference, that represents the Win32 message to process. </param>
		/// <param name="keyData"> One of the <see cref="Keys"/> values that represents the key to process. </param>
		/// <returns> <see langword="true"/> if the keystroke was processed and consumed by the control;
		/// otherwise, <see langword="false"/> to allow further processing. </returns>
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// Ctrl+S shortcut: save preset.
			if (keyData == (Keys.Control | Keys.S))
			{
				SaveCurrentPreset();
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		#endregion Methods: Protected

		#region Methods: Private

		/// <summary>
		/// Initializes loaded config's values.
		/// </summary>
		private void InitializeConfig()
		{
			FirstFilePathTextBox.Text = _config.DefaultPath;
			OutputFilePathTextBox.Text = _config.DefaultPath;

			if (!_config.Presets.IsNullOrEmpty())
			{
				PresetList.Items.AddRange(_config.Presets.Cast<object>().ToArray());

				if (_config.LastSelectedPresetIndex >= ComboBoxMinValue
					&& _config.LastSelectedPresetIndex < PresetList.Items.Count)
				{
					PresetList.SelectedIndex = _config.LastSelectedPresetIndex;
				}
			}

			CopyFirstFileNameCheckbox.Checked = _config.IsCopyingFileName;
			CloseOnFinishCheckbox.Checked = _config.IsClosingOnFinish;
		}

		/// <summary>
		/// Save current config to file.
		/// </summary>
		private void SaveConfigFile()
		{
			// Makes a backup of previous version.
			if (File.Exists(_configFileName))
			{
				File.Copy(_configFileName, _backupConfigFileName, true);
			}

			var configJson = JsonSerializer.Serialize(_config);
			File.WriteAllText(_configFileName, configJson);
		}

		/// <summary>
		/// Prepares new execution command.
		/// </summary>
		/// <returns> New execution command instance. </returns>
		private Command PrepareCommand()
		{
			return new Command(
				FirstInputParamTextBox.Text,
				FirstFilePathTextBox.Text,
				SecondInputParamTextBox.Text,
				SecondFilePathTextBox.Text,
				OutputParameterTextBox.Text,
				OutputFilePathTextBox.Text,
				CloseOnFinishCheckbox.Checked);
		}

		/// <summary>
		/// Prepares new preset.
		/// </summary>
		/// <param name="presetName"> Preset name. </param>
		/// <returns> New preset instance. </returns>
		private Preset PreparePreset(string presetName)
		{
			return new Preset(
				presetName,
				FirstInputParamTextBox.Text,
				SecondInputParamTextBox.Text,
				OutputParameterTextBox.Text,
				CloseOnFinishCheckbox.Checked);
		}

		/// <summary>
		/// Returns output file's short name, with full file path removed.
		/// </summary>
		/// <returns> Output file name. </returns>
		private string GetOutputFileName()
		{
			try
			{
				var fileName = Path.GetFileName(OutputFilePathTextBox.Text);
				return string.IsNullOrEmpty(fileName)
					? LauncherConstants.UnknownName
					: fileName;
			}
			catch
			{
				return LauncherConstants.UnknownName;
			}
		}

		/// <summary>
		/// Shows new preset creation dialog.
		/// </summary>
		/// <returns> Preset name (<see langword="null"/> - if canceled). </returns>
		private string ShowNewPresetForm()
		{
			using var form = new EditPresetForm();
			form.IsOverridingExistingPreset = _config.IsOverridingExistingPreset;
			form.StartPosition = FormStartPosition.CenterParent;
			form.ExistingPresets = _config.Presets?.Select(p => p.Name).ToArray();
			form.ShowDialog();

			_config.IsOverridingExistingPreset = form.IsOverridingExistingPreset;
			return form.PresetName;
		}

		/// <summary>
		/// Shows settings form.
		/// </summary>
		private void ShowSettingsForm()
		{
			using var form = new SettingsForm(_config);
			form.StartPosition = FormStartPosition.CenterParent;
			var result = form.ShowDialog();

			if (result != DialogResult.OK || form.Configuration == null)
			{
				return;
			}

			var resultConfig = form.Configuration;
			_config.FfmpegExePath = resultConfig.FfmpegExePath;
			_config.DefaultPath = resultConfig.DefaultPath;
			_config.StartFfmpegMinimized = resultConfig.StartFfmpegMinimized;
		}

		/// <summary>
		/// Creates new preset.
		/// </summary>
		private void AddNewPreset()
		{
			const int StartIndex = 0;
			var presetName = ShowNewPresetForm();

			if (string.IsNullOrEmpty(presetName))
			{
				return;
			}

			_config.Presets ??= new List<Preset>();
			_currentPreset = PreparePreset(presetName);
			PresetLabel.Text = DefaultPresetLabelText;

			// Specifying StartIndex makes search case-insensitive.
			var existingComboBoxIndex = PresetList.FindStringExact(presetName, StartIndex);
			var existingPresetIndex = _config.Presets.FindIndex(p => p.Name.Equals(presetName, StringComparison.InvariantCultureIgnoreCase));

			// If preset already exists, update current values instead.
			if (_config.Presets != null
				&& existingPresetIndex >= ComboBoxMinValue
				&& existingComboBoxIndex >= ComboBoxMinValue)
			{
				_config.Presets[existingPresetIndex] = _currentPreset;
				PresetList.Items[existingComboBoxIndex] = presetName;
				PresetList.SelectedIndex = existingComboBoxIndex;
				return;
			}

			_config.Presets.Add(_currentPreset);
			PresetList.Items.Add(presetName);
			PresetList.SelectedIndex = PresetList.Items.Count - 1;
		}

		/// <summary>
		/// Saves current preset.
		/// </summary>
		private void SaveCurrentPreset()
		{
			var presetName = PresetList.Text;

			if (string.IsNullOrEmpty(presetName))
			{
				return;
			}

			var activePresetIndex = _config.Presets.FindIndex(p => p.Name.Equals(PresetList.Text));

			if (activePresetIndex < 0)
			{
				MessageBox.Show("Couldn't find active preset by it's name! Consider restarting the application.", "Save preset",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_config.Presets[activePresetIndex] = PreparePreset(presetName);
			PresetLabel.Text = DefaultPresetLabelText;
		}

		/// <summary>
		/// Replace control's text with macro's value.
		/// If control already has text, it will remain unchanged.
		/// If control is empty and macro isn't found, then <see cref="SettingsConfiguration.DefaultPath"/> is set.
		/// </summary>
		/// <param name="textBox"> Control, which will recieve new value. </param>
		/// <param name="parameters"> Parameters, which may store macro and value. </param>
		/// <param name="keywordName"> Macro name. </param>
		private void ReplaceFilePath(Control textBox, string parameters, string keywordName)
		{
			if (textBox == null)
			{
				return;
			}

			var filePath = GetKeywordValue(parameters, keywordName);

			if (!string.IsNullOrEmpty(filePath))
			{
				textBox.Text = filePath;
				return;
			}

			if (string.IsNullOrEmpty(textBox.Text) && !string.IsNullOrEmpty(_config.DefaultPath))
			{
				textBox.Text = _config.DefaultPath;
			}
		}

		/// <summary>
		/// Returns value part of macro in text.
		/// For example: if text contains "{name=\"path\"}", for keyword "name" method would return "path".
		/// </summary>
		/// <param name="initialText"> Initial text. </param>
		/// <param name="keyword"> Keyword name. </param>
		/// <returns> Value of macro. </returns>
		private static string GetKeywordValue(string initialText, string keyword)
		{
			if (string.IsNullOrEmpty(initialText) || string.IsNullOrEmpty(keyword))
			{
				return null;
			}

			var macroRegexPattern = $@"(?<=\{{{keyword}=)(.+?)(?=\}})";
			var regexMatch = Regex.Match(initialText, macroRegexPattern);

			if (!regexMatch.Success)
			{
				return null;
			}

			return regexMatch.Groups[0].Value
				.Trim().Replace("\"", string.Empty);
		}

		/// <summary>
		/// Opens select input file dialog.
		/// </summary>
		/// <param name="targetControl"> Control, which will recieve selected file path. </param>
		/// <param name="title"> Dialog caption. </param>
		/// <param name="filter"> File selection filters. </param>
		/// <param name="filterIndex"> Filter index. </param>
		/// <exception cref="ArgumentNullException"></exception>
		private static void BrowseInputFile(Control targetControl, string title, string filter, int filterIndex)
		{
			_ = targetControl ?? throw new ArgumentNullException(nameof(targetControl));

			using var selectFileDialog = new OpenFileDialog();
			selectFileDialog.Filter = filter;
			selectFileDialog.FilterIndex = filterIndex;
			selectFileDialog.Title = title;
			selectFileDialog.Multiselect = false;

			if (selectFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			targetControl.Text = selectFileDialog.FileName;
		}

		/// <summary>
		/// Opens select output file dialog.
		/// </summary>
		private void BrowseOutputFile()
		{
			const string Filter = LauncherConstants.DefaultOutputFileFormats;
			const int FilterGroupItemsCount = 2;

			var outputParams = OutputParameterTextBox.Text;
			var preferredFormat = GetKeywordValue(outputParams, LauncherConstants.PreferredFormat);
			var fileExtension = $"|*.{preferredFormat}";
			var filterFileExtensionIndex = Filter.IndexOf(fileExtension, StringComparison.InvariantCultureIgnoreCase);
			var preferredFilter = filterFileExtensionIndex >= 0
				? Filter[..(filterFileExtensionIndex + fileExtension.Length)]
				: Filter;

			// If preferred format found, then use it's index, otherwise select last format "All files".
			var filterIndex = preferredFilter.Split('|').Length / FilterGroupItemsCount;

			using var saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Output file";
			saveFileDialog.Filter = Filter;
			saveFileDialog.FilterIndex = filterIndex;
			saveFileDialog.DefaultExt = preferredFormat;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				OutputFilePathTextBox.Text = saveFileDialog.FileName;
			}
		}

		/// <summary>
		/// Opens select output directory dialog.
		/// </summary>
		private void BrowseOutputDirectory()
		{
			using var selectFolderDialog = new CommonOpenFileDialog();
			selectFolderDialog.Title = "Output folder";
			selectFolderDialog.IsFolderPicker = true;

			if (selectFolderDialog.ShowDialog() != CommonFileDialogResult.Ok)
			{
				return;
			}

			OutputFilePathTextBox.Text = CopyFileName(FirstFilePathTextBox.Text, selectFolderDialog.FileName, OutputParameterTextBox.Text);
		}

		/// <summary>
		/// Copies first file's filename to output path if it's necessary.
		/// </summary>
		private void CopyFirstFileNameIfNecessary()
		{
			var firstFilePath = FirstFilePathTextBox.Text;
			var outputFilePath = OutputFilePathTextBox.Text;

			if (!CopyFirstFileNameCheckbox.Checked || string.IsNullOrEmpty(firstFilePath))
			{
				return;
			}

			var fileNameStartIndex = firstFilePath.LastIndexOf('\\') + 1;

			// Make sure that first file's path contains a file name.
			if (fileNameStartIndex >= firstFilePath.Length)
			{
				return;
			}

			var outputDirectory = string.IsNullOrEmpty(outputFilePath)
				? outputFilePath
				: Path.GetDirectoryName(outputFilePath);

			OutputFilePathTextBox.Text = CopyFileName(FirstFilePathTextBox.Text, outputDirectory, OutputParameterTextBox.Text);
		}

		/// <summary>
		/// Copies file name from <see cref="filePath"/> to <see cref="outputDirectory"/>.
		/// </summary>
		/// <param name="filePath"> Path to file, whose name needs to be copied. </param>
		/// <param name="outputDirectory"> Path to target directory. </param>
		/// <param name="outputParameters"> Output file parameters. </param>
		/// <returns> Output file path. </returns>
		private static string CopyFileName(string filePath, string outputDirectory, string outputParameters = null)
		{
			if (string.IsNullOrEmpty(filePath))
			{
				return $"{outputDirectory}\\";
			}

			var fileExtension = !string.IsNullOrEmpty(outputParameters) && outputParameters.Contains($"{{{LauncherConstants.PreferredFormat}=")
				? $".{GetKeywordValue(outputParameters, LauncherConstants.PreferredFormat)}"
				: Path.GetExtension(filePath);

			if (Path.GetDirectoryName(filePath) != outputDirectory)
			{
				return $"{outputDirectory}\\{Path.GetFileNameWithoutExtension(filePath)}{fileExtension}";
			}

			// If output file is in same directory as input file #1, then add "_new" prefix to it.
			var result = $"{outputDirectory}\\{Path.GetFileNameWithoutExtension(filePath)}_new";

			if (!string.IsNullOrEmpty(fileExtension))
			{
				result += $"{fileExtension}";
			}

			return result;
		}

		#endregion Methods: Private

		#region Methods: Event handlers

		#region Tooltips

		/// <summary>
		/// On hover over "Save preset" button.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void SavePresetButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip.Show("Save preset", SavePresetButton);
		}

		/// <summary>
		/// On hover over "New preset" button.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void AddPresetButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip.Show("Add new preset", AddPresetButton);
		}

		/// <summary>
		/// On hover over "Delete preset" button.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void DeletePresetButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip.Show("Delete preset", DeletePresetButton);
		}

		/// <summary>
		/// On hover over "Show settings" button.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void SettingsButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip.Show("Show settings", SettingsButton);
		}

		/// <summary>
		/// On hover over "Close on finish" checkbox.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void CloseOnFinishCheckbox_MouseHover(object sender, EventArgs e)
		{
			ToolTip.Show("Close command prompt when processing finishes. Is automatically closed when enqueued.",
				CloseOnFinishCheckbox);
		}

		#endregion Tooltips

		/// <summary>
		/// Processes application exit.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void OnApplicationExit(object sender, EventArgs e)
		{
			SaveConfigFile();
		}

		/// <summary>
		/// Clear processed command from queue list.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void RemoveQueuedItem(object sender, CommandEventArgs e)
		{
			if (e == null || string.IsNullOrEmpty(e.OutputFileName)
				|| QueueListBox.Items.Count == 0)
			{
				return;
			}

			var processedFileName = Path.GetFileName(e.OutputFileName);
			var queuedItemIndex = QueueListBox.FindStringExact(processedFileName, 0);

			if (queuedItemIndex >= ComboBoxMinValue)
			{
				QueueListBox.Items.RemoveAt(queuedItemIndex);
			}
		}

		/// <summary>
		/// Updates "Preset" label, marking it as edited.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void ChangeLabelForPreset(object sender, EventArgs e)
		{
			if (sender is TextBox { Modified: true })
			{
				PresetLabel.Text = $"{DefaultPresetLabelText} *";
			}
		}

		/// <summary>
		/// Run FFmpeg execution.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void RunProgramButton_Click(object sender, EventArgs e)
		{
			_launcherManager.Execute(PrepareCommand(),
				_config.StartFfmpegMinimized, _config.FfmpegExePath);
		}

		/// <summary>
		/// Enqueue current command.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void QueueExecutionButton_Click(object sender, EventArgs e)
		{
			const bool IsQueued = true;
			QueueListBox.Items.Add(GetOutputFileName());
			_launcherManager.Execute(PrepareCommand(),
				_config.StartFfmpegMinimized, _config.FfmpegExePath, IsQueued);
		}

		/// <summary>
		/// Clear execution queue. Current executions will continue processing.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void ClearQueueButton_Click(object sender, EventArgs e)
		{
			QueueListBox.Items.Clear();
			_launcherManager.ClearQueue();
		}

		/// <summary>
		/// Adds new preset.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void AddPresetButton_Click(object sender, EventArgs e)
		{
			AddNewPreset();
		}

		/// <summary>
		/// Saves current preset.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void SavePresetButton_Click(object sender, EventArgs e)
		{
			if (PresetList.SelectedIndex < ComboBoxMinValue)
			{
				AddNewPreset();
				return;
			}

			SaveCurrentPreset();
		}

		/// <summary>
		/// Deletes current preset.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void DeletePresetButton_Click(object sender, EventArgs e)
		{
			if (_currentPreset == null || PresetList.SelectedIndex < ComboBoxMinValue)
			{
				return;
			}

			var messageReply = MessageBox.Show(this, $"Delete preset \"{_currentPreset.Name}\"?", "Delete",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (messageReply != DialogResult.OK)
			{
				return;
			}

			_config.Presets.Remove(_currentPreset);
			PresetList.Items.RemoveAt(PresetList.SelectedIndex);
			PresetLabel.Text = DefaultPresetLabelText;
		}

		/// <summary>
		/// Opens settings window.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void SettingsButton_Click(object sender, EventArgs e)
		{
			ShowSettingsForm();
		}

		/// <summary>
		/// Processes "Copy File1 name" checkbox change.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void CopyFirstFileNameCheckbox_CheckStateChanged(object sender, EventArgs e)
		{
			_config.IsCopyingFileName = CopyFirstFileNameCheckbox.Checked;
			CopyFirstFileNameIfNecessary();
		}

		/// <summary>
		/// Processes "Close on finish" checkbox change.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void CloseOnFinishCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			_config.IsClosingOnFinish = CloseOnFinishCheckbox.Checked;
		}

		/// <summary>
		/// Processes "Presets" ComboBox index change.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void PresetList_SelectedIndexChanged(object sender, EventArgs e)
		{
			_config.LastSelectedPresetIndex = PresetList.SelectedIndex;
			_currentPreset = PresetList.SelectedIndex < ComboBoxMinValue || _config.Presets.IsNullOrEmpty()
				? null
				: _config.Presets.Find(p => p.Name == PresetList.Text);

			var firstInputParam = FirstInputParamTextBox.Text = _currentPreset?.FirstFileParameter.Parameters ?? string.Empty;
			var secondInputParam = SecondInputParamTextBox.Text = _currentPreset?.SecondFileParameter.Parameters ?? string.Empty;
			var outputParam = OutputParameterTextBox.Text = _currentPreset?.OutputFileParameter.Parameters ?? string.Empty;
			ReplaceFilePath(FirstFilePathTextBox, firstInputParam, LauncherConstants.FirstFileName);

			if (!string.IsNullOrEmpty(secondInputParam))
			{
				ReplaceFilePath(SecondFilePathTextBox, secondInputParam, LauncherConstants.SecondFileName);
			}
			else
			{
				SecondFilePathTextBox.Text = string.Empty;
			}

			if (!string.IsNullOrEmpty(OutputFilePathTextBox.Text))
			{
				ReplaceFilePath(OutputFilePathTextBox, outputParam, LauncherConstants.OutputFileName);
			}

			PresetLabel.Text = DefaultPresetLabelText;
		}

		/// <summary>
		/// Opens dialog for selecting first input file.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void BrowseFirstFileButton_Click(object sender, EventArgs e)
		{
			BrowseInputFile(FirstFilePathTextBox, "Input file #1", LauncherConstants.DefaultInputFileFormats, 1);
			CopyFirstFileNameIfNecessary();
		}

		/// <summary>
		/// Opens dialog for selecting second input file.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void BrowseSecondFileButton_Click(object sender, EventArgs e)
		{
			BrowseInputFile(SecondFilePathTextBox, "Input file #2", LauncherConstants.DefaultInputFileFormats, 1);
			CopyFirstFileNameIfNecessary();
		}

		/// <summary>
		/// Opens dialog for selecting output file or directory.
		/// </summary>
		/// <param name="sender"> Event raising object. </param>
		/// <param name="e"> Event arguments. </param>
		private void BrowseOutputFileButton_Click(object sender, EventArgs e)
		{
			if (CopyFirstFileNameCheckbox.Checked)
			{
				BrowseOutputDirectory();
				return;
			}

			BrowseOutputFile();
		}

		#endregion Methods: Event handlers
	}
}
