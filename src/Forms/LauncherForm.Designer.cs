namespace Mugnum.FFmpegLauncher.Forms
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
			this.QueueListBox = new System.Windows.Forms.ListBox();
			this.QueueLabel = new System.Windows.Forms.Label();
			this.RunProgramButton = new System.Windows.Forms.Button();
			this.SavePresetButton = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.DeletePresetButton = new System.Windows.Forms.Button();
			this.AddPresetButton = new System.Windows.Forms.Button();
			this.labelPreset = new System.Windows.Forms.Label();
			this.PresetList = new System.Windows.Forms.ComboBox();
			this.CopyFirstFileNameCheckbox = new System.Windows.Forms.CheckBox();
			this.SecondInputParamTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SecondFilePathTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.CloseOnFinishCheckbox = new System.Windows.Forms.CheckBox();
			this.BrowseSecondFileButton = new System.Windows.Forms.Button();
			this.BrowseOutputFileButton = new System.Windows.Forms.Button();
			this.OutputFilePathTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.BrowseFirstFileButton = new System.Windows.Forms.Button();
			this.FirstFilePathTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.OutputParameterTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.FirstInputParamTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.QueueExecutionButton = new System.Windows.Forms.Button();
			this.ClearQueueButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// QueueListBox
			// 
			this.QueueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.QueueListBox.Enabled = false;
			this.QueueListBox.FormattingEnabled = true;
			this.QueueListBox.Location = new System.Drawing.Point(721, 27);
			this.QueueListBox.Name = "QueueListBox";
			this.QueueListBox.ScrollAlwaysVisible = true;
			this.QueueListBox.Size = new System.Drawing.Size(162, 355);
			this.QueueListBox.TabIndex = 98;
			// 
			// QueueLabel
			// 
			this.QueueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.QueueLabel.AutoSize = true;
			this.QueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.QueueLabel.Location = new System.Drawing.Point(721, 11);
			this.QueueLabel.Name = "QueueLabel";
			this.QueueLabel.Size = new System.Drawing.Size(39, 13);
			this.QueueLabel.TabIndex = 97;
			this.QueueLabel.Text = "Queue";
			// 
			// RunProgramButton
			// 
			this.RunProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RunProgramButton.Location = new System.Drawing.Point(567, 431);
			this.RunProgramButton.Name = "RunProgramButton";
			this.RunProgramButton.Size = new System.Drawing.Size(62, 36);
			this.RunProgramButton.TabIndex = 96;
			this.RunProgramButton.Text = "Run";
			this.RunProgramButton.UseVisualStyleBackColor = true;
			this.RunProgramButton.Click += new System.EventHandler(this.RunProgramButton_Click);
			// 
			// SavePresetButton
			// 
			this.SavePresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SavePresetButton.ImageIndex = 2;
			this.SavePresetButton.ImageList = this.imageList1;
			this.SavePresetButton.Location = new System.Drawing.Point(258, 431);
			this.SavePresetButton.Name = "SavePresetButton";
			this.SavePresetButton.Size = new System.Drawing.Size(24, 24);
			this.SavePresetButton.TabIndex = 90;
			this.SavePresetButton.UseVisualStyleBackColor = true;
			this.SavePresetButton.Click += new System.EventHandler(this.SavePresetButton_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Add_16x.png");
			this.imageList1.Images.SetKeyName(1, "Remove_color_16x.png");
			this.imageList1.Images.SetKeyName(2, "Save_16x.png");
			// 
			// DeletePresetButton
			// 
			this.DeletePresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeletePresetButton.ImageIndex = 1;
			this.DeletePresetButton.ImageList = this.imageList1;
			this.DeletePresetButton.Location = new System.Drawing.Point(318, 431);
			this.DeletePresetButton.Name = "DeletePresetButton";
			this.DeletePresetButton.Size = new System.Drawing.Size(24, 24);
			this.DeletePresetButton.TabIndex = 92;
			this.DeletePresetButton.UseVisualStyleBackColor = true;
			this.DeletePresetButton.Click += new System.EventHandler(this.DeletePresetButton_Click);
			// 
			// AddPresetButton
			// 
			this.AddPresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddPresetButton.ImageIndex = 0;
			this.AddPresetButton.ImageList = this.imageList1;
			this.AddPresetButton.Location = new System.Drawing.Point(288, 431);
			this.AddPresetButton.Name = "AddPresetButton";
			this.AddPresetButton.Size = new System.Drawing.Size(24, 24);
			this.AddPresetButton.TabIndex = 91;
			this.AddPresetButton.UseVisualStyleBackColor = true;
			this.AddPresetButton.Click += new System.EventHandler(this.AddPresetButton_Click);
			// 
			// labelPreset
			// 
			this.labelPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelPreset.AutoSize = true;
			this.labelPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPreset.Location = new System.Drawing.Point(17, 434);
			this.labelPreset.Name = "labelPreset";
			this.labelPreset.Size = new System.Drawing.Size(40, 13);
			this.labelPreset.TabIndex = 88;
			this.labelPreset.Text = "Preset:";
			// 
			// PresetList
			// 
			this.PresetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PresetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PresetList.FormattingEnabled = true;
			this.PresetList.Location = new System.Drawing.Point(80, 431);
			this.PresetList.Name = "PresetList";
			this.PresetList.Size = new System.Drawing.Size(169, 21);
			this.PresetList.TabIndex = 89;
			this.PresetList.SelectedIndexChanged += new System.EventHandler(this.PresetList_SelectedIndexChanged);
			// 
			// CopyFirstFileNameCheckbox
			// 
			this.CopyFirstFileNameCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyFirstFileNameCheckbox.AutoSize = true;
			this.CopyFirstFileNameCheckbox.Location = new System.Drawing.Point(455, 430);
			this.CopyFirstFileNameCheckbox.Name = "CopyFirstFileNameCheckbox";
			this.CopyFirstFileNameCheckbox.Size = new System.Drawing.Size(104, 17);
			this.CopyFirstFileNameCheckbox.TabIndex = 93;
			this.CopyFirstFileNameCheckbox.Text = "Copy File1 name";
			this.CopyFirstFileNameCheckbox.UseVisualStyleBackColor = true;
			this.CopyFirstFileNameCheckbox.CheckStateChanged += new System.EventHandler(this.CopyFirstFileNameCheckbox_CheckStateChanged);
			// 
			// SecondInputParamTextBox
			// 
			this.SecondInputParamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SecondInputParamTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SecondInputParamTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.SecondInputParamTextBox.Location = new System.Drawing.Point(16, 136);
			this.SecondInputParamTextBox.Multiline = true;
			this.SecondInputParamTextBox.Name = "SecondInputParamTextBox";
			this.SecondInputParamTextBox.Size = new System.Drawing.Size(682, 47);
			this.SecondInputParamTextBox.TabIndex = 79;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(16, 119);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 13);
			this.label7.TabIndex = 78;
			this.label7.Text = "Input parameters #2";
			// 
			// SecondFilePathTextBox
			// 
			this.SecondFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SecondFilePathTextBox.Location = new System.Drawing.Point(80, 191);
			this.SecondFilePathTextBox.Name = "SecondFilePathTextBox";
			this.SecondFilePathTextBox.Size = new System.Drawing.Size(512, 20);
			this.SecondFilePathTextBox.TabIndex = 81;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(16, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 80;
			this.label6.Text = "File 2:";
			// 
			// CloseOnFinishCheckbox
			// 
			this.CloseOnFinishCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseOnFinishCheckbox.AutoSize = true;
			this.CloseOnFinishCheckbox.Checked = true;
			this.CloseOnFinishCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CloseOnFinishCheckbox.Location = new System.Drawing.Point(455, 449);
			this.CloseOnFinishCheckbox.Name = "CloseOnFinishCheckbox";
			this.CloseOnFinishCheckbox.Size = new System.Drawing.Size(94, 17);
			this.CloseOnFinishCheckbox.TabIndex = 94;
			this.CloseOnFinishCheckbox.Text = "Close on finish";
			this.CloseOnFinishCheckbox.UseVisualStyleBackColor = true;
			this.CloseOnFinishCheckbox.CheckedChanged += new System.EventHandler(this.CloseOnFinishCheckbox_CheckedChanged);
			// 
			// BrowseSecondFileButton
			// 
			this.BrowseSecondFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseSecondFileButton.Location = new System.Drawing.Point(608, 189);
			this.BrowseSecondFileButton.Name = "BrowseSecondFileButton";
			this.BrowseSecondFileButton.Size = new System.Drawing.Size(90, 23);
			this.BrowseSecondFileButton.TabIndex = 82;
			this.BrowseSecondFileButton.Text = "Browse...";
			this.BrowseSecondFileButton.UseVisualStyleBackColor = true;
			this.BrowseSecondFileButton.Click += new System.EventHandler(this.BrowseSecondFileButton_Click);
			// 
			// BrowseOutputFileButton
			// 
			this.BrowseOutputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseOutputFileButton.Location = new System.Drawing.Point(608, 392);
			this.BrowseOutputFileButton.Name = "BrowseOutputFileButton";
			this.BrowseOutputFileButton.Size = new System.Drawing.Size(90, 23);
			this.BrowseOutputFileButton.TabIndex = 87;
			this.BrowseOutputFileButton.Text = "Browse...";
			this.BrowseOutputFileButton.UseVisualStyleBackColor = true;
			this.BrowseOutputFileButton.Click += new System.EventHandler(this.BrowseOutputFileButton_Click);
			// 
			// OutputFilePathTextBox
			// 
			this.OutputFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputFilePathTextBox.Location = new System.Drawing.Point(80, 394);
			this.OutputFilePathTextBox.Name = "OutputFilePathTextBox";
			this.OutputFilePathTextBox.Size = new System.Drawing.Size(512, 20);
			this.OutputFilePathTextBox.TabIndex = 86;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(16, 397);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 85;
			this.label4.Text = "Output file:";
			// 
			// BrowseFirstFileButton
			// 
			this.BrowseFirstFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseFirstFileButton.Location = new System.Drawing.Point(608, 80);
			this.BrowseFirstFileButton.Name = "BrowseFirstFileButton";
			this.BrowseFirstFileButton.Size = new System.Drawing.Size(90, 23);
			this.BrowseFirstFileButton.TabIndex = 77;
			this.BrowseFirstFileButton.Text = "Browse...";
			this.BrowseFirstFileButton.UseVisualStyleBackColor = true;
			this.BrowseFirstFileButton.Click += new System.EventHandler(this.BrowseFirstFileButton_Click);
			// 
			// FirstFilePathTextBox
			// 
			this.FirstFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FirstFilePathTextBox.Location = new System.Drawing.Point(80, 82);
			this.FirstFilePathTextBox.Name = "FirstFilePathTextBox";
			this.FirstFilePathTextBox.Size = new System.Drawing.Size(512, 20);
			this.FirstFilePathTextBox.TabIndex = 76;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(16, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 75;
			this.label3.Text = "File 1:";
			// 
			// OutputParameterTextBox
			// 
			this.OutputParameterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputParameterTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OutputParameterTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.OutputParameterTextBox.Location = new System.Drawing.Point(16, 248);
			this.OutputParameterTextBox.Multiline = true;
			this.OutputParameterTextBox.Name = "OutputParameterTextBox";
			this.OutputParameterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.OutputParameterTextBox.Size = new System.Drawing.Size(682, 131);
			this.OutputParameterTextBox.TabIndex = 84;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(16, 232);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 83;
			this.label2.Text = "Output parameters";
			// 
			// FirstInputParamTextBox
			// 
			this.FirstInputParamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FirstInputParamTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FirstInputParamTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FirstInputParamTextBox.Location = new System.Drawing.Point(16, 27);
			this.FirstInputParamTextBox.Multiline = true;
			this.FirstInputParamTextBox.Name = "FirstInputParamTextBox";
			this.FirstInputParamTextBox.Size = new System.Drawing.Size(682, 47);
			this.FirstInputParamTextBox.TabIndex = 74;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(16, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 73;
			this.label1.Text = "Input parameters #1";
			// 
			// QueueExecutionButton
			// 
			this.QueueExecutionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.QueueExecutionButton.Location = new System.Drawing.Point(635, 431);
			this.QueueExecutionButton.Name = "QueueExecutionButton";
			this.QueueExecutionButton.Size = new System.Drawing.Size(63, 36);
			this.QueueExecutionButton.TabIndex = 95;
			this.QueueExecutionButton.Text = "Queue";
			this.QueueExecutionButton.UseVisualStyleBackColor = true;
			this.QueueExecutionButton.Click += new System.EventHandler(this.QueueExecutionButton_Click);
			// 
			// ClearQueueButton
			// 
			this.ClearQueueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearQueueButton.Location = new System.Drawing.Point(721, 431);
			this.ClearQueueButton.Name = "ClearQueueButton";
			this.ClearQueueButton.Size = new System.Drawing.Size(162, 36);
			this.ClearQueueButton.TabIndex = 99;
			this.ClearQueueButton.Text = "Clear queue";
			this.ClearQueueButton.UseVisualStyleBackColor = true;
			this.ClearQueueButton.Click += new System.EventHandler(this.ClearQueueButton_Click);
			// 
			// LauncherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 478);
			this.Controls.Add(this.ClearQueueButton);
			this.Controls.Add(this.QueueListBox);
			this.Controls.Add(this.QueueLabel);
			this.Controls.Add(this.RunProgramButton);
			this.Controls.Add(this.SavePresetButton);
			this.Controls.Add(this.DeletePresetButton);
			this.Controls.Add(this.AddPresetButton);
			this.Controls.Add(this.labelPreset);
			this.Controls.Add(this.PresetList);
			this.Controls.Add(this.CopyFirstFileNameCheckbox);
			this.Controls.Add(this.SecondInputParamTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.SecondFilePathTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.CloseOnFinishCheckbox);
			this.Controls.Add(this.BrowseSecondFileButton);
			this.Controls.Add(this.BrowseOutputFileButton);
			this.Controls.Add(this.OutputFilePathTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BrowseFirstFileButton);
			this.Controls.Add(this.FirstFilePathTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.OutputParameterTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.FirstInputParamTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.QueueExecutionButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LauncherForm";
			this.Text = "FFmpeg Launcher";
			this.ResumeLayout(false);
			this.PerformLayout();

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