﻿namespace Mugnum.FFmpegLauncher.Forms
{
	partial class LauncherForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
			QueueListBox = new System.Windows.Forms.ListBox();
			QueueLabel = new System.Windows.Forms.Label();
			RunProgramButton = new System.Windows.Forms.Button();
			SavePresetButton = new System.Windows.Forms.Button();
			imageList1 = new System.Windows.Forms.ImageList(components);
			DeletePresetButton = new System.Windows.Forms.Button();
			AddPresetButton = new System.Windows.Forms.Button();
			labelPreset = new System.Windows.Forms.Label();
			PresetList = new System.Windows.Forms.ComboBox();
			CopyFirstFileNameCheckbox = new System.Windows.Forms.CheckBox();
			SecondInputParamTextBox = new System.Windows.Forms.TextBox();
			label7 = new System.Windows.Forms.Label();
			SecondFilePathTextBox = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			CloseOnFinishCheckbox = new System.Windows.Forms.CheckBox();
			BrowseSecondFileButton = new System.Windows.Forms.Button();
			BrowseOutputFileButton = new System.Windows.Forms.Button();
			OutputFilePathTextBox = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			BrowseFirstFileButton = new System.Windows.Forms.Button();
			FirstFilePathTextBox = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			OutputParameterTextBox = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			FirstInputParamTextBox = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			QueueExecutionButton = new System.Windows.Forms.Button();
			ClearQueueButton = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// QueueListBox
			// 
			QueueListBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			QueueListBox.Enabled = false;
			QueueListBox.FormattingEnabled = true;
			QueueListBox.ItemHeight = 15;
			QueueListBox.Location = new System.Drawing.Point(721, 27);
			QueueListBox.Name = "QueueListBox";
			QueueListBox.ScrollAlwaysVisible = true;
			QueueListBox.Size = new System.Drawing.Size(162, 349);
			QueueListBox.TabIndex = 98;
			// 
			// QueueLabel
			// 
			QueueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			QueueLabel.AutoSize = true;
			QueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			QueueLabel.Location = new System.Drawing.Point(721, 11);
			QueueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			QueueLabel.Name = "QueueLabel";
			QueueLabel.Size = new System.Drawing.Size(39, 13);
			QueueLabel.TabIndex = 97;
			QueueLabel.Text = "Queue";
			// 
			// RunProgramButton
			// 
			RunProgramButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			RunProgramButton.Location = new System.Drawing.Point(567, 431);
			RunProgramButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			RunProgramButton.Name = "RunProgramButton";
			RunProgramButton.Size = new System.Drawing.Size(62, 36);
			RunProgramButton.TabIndex = 96;
			RunProgramButton.Text = "Run";
			RunProgramButton.UseVisualStyleBackColor = true;
			RunProgramButton.Click += RunProgramButton_Click;
			// 
			// SavePresetButton
			// 
			SavePresetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			SavePresetButton.ImageIndex = 2;
			SavePresetButton.ImageList = imageList1;
			SavePresetButton.Location = new System.Drawing.Point(258, 431);
			SavePresetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			SavePresetButton.Name = "SavePresetButton";
			SavePresetButton.Size = new System.Drawing.Size(24, 24);
			SavePresetButton.TabIndex = 90;
			SavePresetButton.UseVisualStyleBackColor = true;
			SavePresetButton.Click += SavePresetButton_Click;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = System.Drawing.Color.Transparent;
			imageList1.Images.SetKeyName(0, "Add_16x.png");
			imageList1.Images.SetKeyName(1, "Remove_color_16x.png");
			imageList1.Images.SetKeyName(2, "Save_16x.png");
			// 
			// DeletePresetButton
			// 
			DeletePresetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			DeletePresetButton.ImageIndex = 1;
			DeletePresetButton.ImageList = imageList1;
			DeletePresetButton.Location = new System.Drawing.Point(318, 431);
			DeletePresetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			DeletePresetButton.Name = "DeletePresetButton";
			DeletePresetButton.Size = new System.Drawing.Size(24, 24);
			DeletePresetButton.TabIndex = 92;
			DeletePresetButton.UseVisualStyleBackColor = true;
			DeletePresetButton.Click += DeletePresetButton_Click;
			// 
			// AddPresetButton
			// 
			AddPresetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			AddPresetButton.ImageIndex = 0;
			AddPresetButton.ImageList = imageList1;
			AddPresetButton.Location = new System.Drawing.Point(288, 431);
			AddPresetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			AddPresetButton.Name = "AddPresetButton";
			AddPresetButton.Size = new System.Drawing.Size(24, 24);
			AddPresetButton.TabIndex = 91;
			AddPresetButton.UseVisualStyleBackColor = true;
			AddPresetButton.Click += AddPresetButton_Click;
			// 
			// labelPreset
			// 
			labelPreset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			labelPreset.AutoSize = true;
			labelPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			labelPreset.Location = new System.Drawing.Point(17, 434);
			labelPreset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			labelPreset.Name = "labelPreset";
			labelPreset.Size = new System.Drawing.Size(40, 13);
			labelPreset.TabIndex = 88;
			labelPreset.Text = "Preset:";
			// 
			// PresetList
			// 
			PresetList.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			PresetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			PresetList.FormattingEnabled = true;
			PresetList.Location = new System.Drawing.Point(80, 431);
			PresetList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			PresetList.Name = "PresetList";
			PresetList.Size = new System.Drawing.Size(169, 23);
			PresetList.TabIndex = 89;
			PresetList.SelectedIndexChanged += PresetList_SelectedIndexChanged;
			// 
			// CopyFirstFileNameCheckbox
			// 
			CopyFirstFileNameCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			CopyFirstFileNameCheckbox.AutoSize = true;
			CopyFirstFileNameCheckbox.Location = new System.Drawing.Point(445, 428);
			CopyFirstFileNameCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			CopyFirstFileNameCheckbox.Name = "CopyFirstFileNameCheckbox";
			CopyFirstFileNameCheckbox.Size = new System.Drawing.Size(114, 19);
			CopyFirstFileNameCheckbox.TabIndex = 93;
			CopyFirstFileNameCheckbox.Text = "Copy File1 name";
			CopyFirstFileNameCheckbox.UseVisualStyleBackColor = true;
			CopyFirstFileNameCheckbox.CheckStateChanged += CopyFirstFileNameCheckbox_CheckStateChanged;
			// 
			// SecondInputParamTextBox
			// 
			SecondInputParamTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			SecondInputParamTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			SecondInputParamTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			SecondInputParamTextBox.Location = new System.Drawing.Point(16, 136);
			SecondInputParamTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			SecondInputParamTextBox.Multiline = true;
			SecondInputParamTextBox.Name = "SecondInputParamTextBox";
			SecondInputParamTextBox.Size = new System.Drawing.Size(682, 47);
			SecondInputParamTextBox.TabIndex = 79;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label7.Location = new System.Drawing.Point(16, 119);
			label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(102, 13);
			label7.TabIndex = 78;
			label7.Text = "Input parameters #2";
			// 
			// SecondFilePathTextBox
			// 
			SecondFilePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			SecondFilePathTextBox.Location = new System.Drawing.Point(80, 191);
			SecondFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			SecondFilePathTextBox.Name = "SecondFilePathTextBox";
			SecondFilePathTextBox.Size = new System.Drawing.Size(512, 23);
			SecondFilePathTextBox.TabIndex = 81;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label6.Location = new System.Drawing.Point(16, 194);
			label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(35, 13);
			label6.TabIndex = 80;
			label6.Text = "File 2:";
			// 
			// CloseOnFinishCheckbox
			// 
			CloseOnFinishCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			CloseOnFinishCheckbox.AutoSize = true;
			CloseOnFinishCheckbox.Checked = true;
			CloseOnFinishCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			CloseOnFinishCheckbox.Location = new System.Drawing.Point(445, 447);
			CloseOnFinishCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			CloseOnFinishCheckbox.Name = "CloseOnFinishCheckbox";
			CloseOnFinishCheckbox.Size = new System.Drawing.Size(104, 19);
			CloseOnFinishCheckbox.TabIndex = 94;
			CloseOnFinishCheckbox.Text = "Close on finish";
			CloseOnFinishCheckbox.UseVisualStyleBackColor = true;
			CloseOnFinishCheckbox.CheckedChanged += CloseOnFinishCheckbox_CheckedChanged;
			// 
			// BrowseSecondFileButton
			// 
			BrowseSecondFileButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			BrowseSecondFileButton.Location = new System.Drawing.Point(608, 189);
			BrowseSecondFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			BrowseSecondFileButton.Name = "BrowseSecondFileButton";
			BrowseSecondFileButton.Size = new System.Drawing.Size(90, 23);
			BrowseSecondFileButton.TabIndex = 82;
			BrowseSecondFileButton.Text = "Browse...";
			BrowseSecondFileButton.UseVisualStyleBackColor = true;
			BrowseSecondFileButton.Click += BrowseSecondFileButton_Click;
			// 
			// BrowseOutputFileButton
			// 
			BrowseOutputFileButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			BrowseOutputFileButton.Location = new System.Drawing.Point(608, 392);
			BrowseOutputFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			BrowseOutputFileButton.Name = "BrowseOutputFileButton";
			BrowseOutputFileButton.Size = new System.Drawing.Size(90, 23);
			BrowseOutputFileButton.TabIndex = 87;
			BrowseOutputFileButton.Text = "Browse...";
			BrowseOutputFileButton.UseVisualStyleBackColor = true;
			BrowseOutputFileButton.Click += BrowseOutputFileButton_Click;
			// 
			// OutputFilePathTextBox
			// 
			OutputFilePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			OutputFilePathTextBox.Location = new System.Drawing.Point(80, 394);
			OutputFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			OutputFilePathTextBox.Name = "OutputFilePathTextBox";
			OutputFilePathTextBox.Size = new System.Drawing.Size(512, 23);
			OutputFilePathTextBox.TabIndex = 86;
			// 
			// label4
			// 
			label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label4.Location = new System.Drawing.Point(16, 397);
			label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(58, 13);
			label4.TabIndex = 85;
			label4.Text = "Output file:";
			// 
			// BrowseFirstFileButton
			// 
			BrowseFirstFileButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			BrowseFirstFileButton.Location = new System.Drawing.Point(608, 80);
			BrowseFirstFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			BrowseFirstFileButton.Name = "BrowseFirstFileButton";
			BrowseFirstFileButton.Size = new System.Drawing.Size(90, 23);
			BrowseFirstFileButton.TabIndex = 77;
			BrowseFirstFileButton.Text = "Browse...";
			BrowseFirstFileButton.UseVisualStyleBackColor = true;
			BrowseFirstFileButton.Click += BrowseFirstFileButton_Click;
			// 
			// FirstFilePathTextBox
			// 
			FirstFilePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			FirstFilePathTextBox.Location = new System.Drawing.Point(80, 82);
			FirstFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			FirstFilePathTextBox.Name = "FirstFilePathTextBox";
			FirstFilePathTextBox.Size = new System.Drawing.Size(512, 23);
			FirstFilePathTextBox.TabIndex = 76;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label3.Location = new System.Drawing.Point(16, 85);
			label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(35, 13);
			label3.TabIndex = 75;
			label3.Text = "File 1:";
			// 
			// OutputParameterTextBox
			// 
			OutputParameterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			OutputParameterTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			OutputParameterTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			OutputParameterTextBox.Location = new System.Drawing.Point(16, 248);
			OutputParameterTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			OutputParameterTextBox.Multiline = true;
			OutputParameterTextBox.Name = "OutputParameterTextBox";
			OutputParameterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			OutputParameterTextBox.Size = new System.Drawing.Size(682, 131);
			OutputParameterTextBox.TabIndex = 84;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label2.Location = new System.Drawing.Point(16, 232);
			label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(94, 13);
			label2.TabIndex = 83;
			label2.Text = "Output parameters";
			// 
			// FirstInputParamTextBox
			// 
			FirstInputParamTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			FirstInputParamTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			FirstInputParamTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			FirstInputParamTextBox.Location = new System.Drawing.Point(16, 27);
			FirstInputParamTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			FirstInputParamTextBox.Multiline = true;
			FirstInputParamTextBox.Name = "FirstInputParamTextBox";
			FirstInputParamTextBox.Size = new System.Drawing.Size(682, 47);
			FirstInputParamTextBox.TabIndex = 74;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label1.Location = new System.Drawing.Point(16, 11);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(102, 13);
			label1.TabIndex = 73;
			label1.Text = "Input parameters #1";
			// 
			// QueueExecutionButton
			// 
			QueueExecutionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			QueueExecutionButton.Location = new System.Drawing.Point(635, 431);
			QueueExecutionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			QueueExecutionButton.Name = "QueueExecutionButton";
			QueueExecutionButton.Size = new System.Drawing.Size(63, 36);
			QueueExecutionButton.TabIndex = 95;
			QueueExecutionButton.Text = "Queue";
			QueueExecutionButton.UseVisualStyleBackColor = true;
			QueueExecutionButton.Click += QueueExecutionButton_Click;
			// 
			// ClearQueueButton
			// 
			ClearQueueButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			ClearQueueButton.Location = new System.Drawing.Point(721, 431);
			ClearQueueButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			ClearQueueButton.Name = "ClearQueueButton";
			ClearQueueButton.Size = new System.Drawing.Size(162, 36);
			ClearQueueButton.TabIndex = 99;
			ClearQueueButton.Text = "Clear queue";
			ClearQueueButton.UseVisualStyleBackColor = true;
			ClearQueueButton.Click += ClearQueueButton_Click;
			// 
			// LauncherForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(899, 478);
			Controls.Add(ClearQueueButton);
			Controls.Add(QueueListBox);
			Controls.Add(QueueLabel);
			Controls.Add(RunProgramButton);
			Controls.Add(SavePresetButton);
			Controls.Add(DeletePresetButton);
			Controls.Add(AddPresetButton);
			Controls.Add(labelPreset);
			Controls.Add(PresetList);
			Controls.Add(CopyFirstFileNameCheckbox);
			Controls.Add(SecondInputParamTextBox);
			Controls.Add(label7);
			Controls.Add(SecondFilePathTextBox);
			Controls.Add(label6);
			Controls.Add(CloseOnFinishCheckbox);
			Controls.Add(BrowseSecondFileButton);
			Controls.Add(BrowseOutputFileButton);
			Controls.Add(OutputFilePathTextBox);
			Controls.Add(label4);
			Controls.Add(BrowseFirstFileButton);
			Controls.Add(FirstFilePathTextBox);
			Controls.Add(label3);
			Controls.Add(OutputParameterTextBox);
			Controls.Add(label2);
			Controls.Add(FirstInputParamTextBox);
			Controls.Add(label1);
			Controls.Add(QueueExecutionButton);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "LauncherForm";
			Text = "FFmpeg Launcher";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ListBox QueueListBox;
		private System.Windows.Forms.Label QueueLabel;
		private System.Windows.Forms.Button RunProgramButton;
		private System.Windows.Forms.Button SavePresetButton;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button DeletePresetButton;
		private System.Windows.Forms.Button AddPresetButton;
		private System.Windows.Forms.Label labelPreset;
		internal System.Windows.Forms.ComboBox PresetList;
		private System.Windows.Forms.CheckBox CopyFirstFileNameCheckbox;
		private System.Windows.Forms.TextBox SecondInputParamTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox SecondFilePathTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox CloseOnFinishCheckbox;
		private System.Windows.Forms.Button BrowseSecondFileButton;
		private System.Windows.Forms.Button BrowseOutputFileButton;
		private System.Windows.Forms.TextBox OutputFilePathTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BrowseFirstFileButton;
		private System.Windows.Forms.TextBox FirstFilePathTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox OutputParameterTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FirstInputParamTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button QueueExecutionButton;
		private System.Windows.Forms.Button ClearQueueButton;
	}
}