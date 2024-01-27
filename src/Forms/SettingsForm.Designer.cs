namespace Mugnum.FFmpegLauncher.Forms
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			FfmpegExePathTextBox = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			BrowseFfmpegExePathButton = new System.Windows.Forms.Button();
			ImageList = new System.Windows.Forms.ImageList(components);
			BrowseDefaultDirectoryButton = new System.Windows.Forms.Button();
			DefaultDirectoryTextBox = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			StartFfmpegMinimizedCheckBox = new System.Windows.Forms.CheckBox();
			CancelButton = new System.Windows.Forms.Button();
			SaveButton = new System.Windows.Forms.Button();
			ToolTip = new System.Windows.Forms.ToolTip(components);
			SuspendLayout();
			// 
			// FfmpegExePathTextBox
			// 
			FfmpegExePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			FfmpegExePathTextBox.Location = new System.Drawing.Point(102, 11);
			FfmpegExePathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			FfmpegExePathTextBox.Name = "FfmpegExePathTextBox";
			FfmpegExePathTextBox.Size = new System.Drawing.Size(452, 23);
			FfmpegExePathTextBox.TabIndex = 78;
			FfmpegExePathTextBox.Tag = "";
			FfmpegExePathTextBox.MouseHover += FfmpegExePathTextBox_MouseHover;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label3.Location = new System.Drawing.Point(13, 15);
			label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(65, 13);
			label3.TabIndex = 77;
			label3.Text = "FFmpeg exe";
			// 
			// BrowseFfmpegExePathButton
			// 
			BrowseFfmpegExePathButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			BrowseFfmpegExePathButton.ImageIndex = 0;
			BrowseFfmpegExePathButton.ImageList = ImageList;
			BrowseFfmpegExePathButton.Location = new System.Drawing.Point(561, 11);
			BrowseFfmpegExePathButton.Name = "BrowseFfmpegExePathButton";
			BrowseFfmpegExePathButton.Size = new System.Drawing.Size(25, 23);
			BrowseFfmpegExePathButton.TabIndex = 79;
			BrowseFfmpegExePathButton.Tag = "Browse...";
			BrowseFfmpegExePathButton.UseVisualStyleBackColor = true;
			BrowseFfmpegExePathButton.Click += BrowseFfmpegExePathButton_Click;
			// 
			// ImageList
			// 
			ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			ImageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList.ImageStream");
			ImageList.TransparentColor = System.Drawing.Color.Transparent;
			ImageList.Images.SetKeyName(0, "FolderOpened.png");
			ImageList.Images.SetKeyName(1, "Save.png");
			// 
			// BrowseDefaultDirectoryButton
			// 
			BrowseDefaultDirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			BrowseDefaultDirectoryButton.ImageIndex = 0;
			BrowseDefaultDirectoryButton.ImageList = ImageList;
			BrowseDefaultDirectoryButton.Location = new System.Drawing.Point(561, 40);
			BrowseDefaultDirectoryButton.Name = "BrowseDefaultDirectoryButton";
			BrowseDefaultDirectoryButton.Size = new System.Drawing.Size(25, 23);
			BrowseDefaultDirectoryButton.TabIndex = 82;
			BrowseDefaultDirectoryButton.Tag = "Browse...";
			BrowseDefaultDirectoryButton.UseVisualStyleBackColor = true;
			BrowseDefaultDirectoryButton.Click += BrowseDefaultDirectoryButton_Click;
			// 
			// DefaultDirectoryTextBox
			// 
			DefaultDirectoryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			DefaultDirectoryTextBox.Location = new System.Drawing.Point(102, 40);
			DefaultDirectoryTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			DefaultDirectoryTextBox.Name = "DefaultDirectoryTextBox";
			DefaultDirectoryTextBox.Size = new System.Drawing.Size(452, 23);
			DefaultDirectoryTextBox.TabIndex = 81;
			DefaultDirectoryTextBox.Tag = "";
			DefaultDirectoryTextBox.MouseHover += DefaultDirectoryTextBox_MouseHover;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label1.Location = new System.Drawing.Point(13, 44);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(84, 13);
			label1.TabIndex = 80;
			label1.Text = "Default directory";
			// 
			// StartFfmpegMinimizedCheckBox
			// 
			StartFfmpegMinimizedCheckBox.AutoSize = true;
			StartFfmpegMinimizedCheckBox.Location = new System.Drawing.Point(12, 82);
			StartFfmpegMinimizedCheckBox.Name = "StartFfmpegMinimizedCheckBox";
			StartFfmpegMinimizedCheckBox.Size = new System.Drawing.Size(155, 19);
			StartFfmpegMinimizedCheckBox.TabIndex = 83;
			StartFfmpegMinimizedCheckBox.Tag = "";
			StartFfmpegMinimizedCheckBox.Text = "Start FFmpeg minimized";
			StartFfmpegMinimizedCheckBox.UseVisualStyleBackColor = true;
			StartFfmpegMinimizedCheckBox.MouseHover += StartFfmpegMinimizedCheckBox_MouseHover;
			// 
			// CancelButton
			// 
			CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			CancelButton.Location = new System.Drawing.Point(507, 104);
			CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new System.Drawing.Size(79, 29);
			CancelButton.TabIndex = 85;
			CancelButton.Text = "Cancel";
			CancelButton.UseVisualStyleBackColor = true;
			// 
			// SaveButton
			// 
			SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			SaveButton.ImageIndex = 1;
			SaveButton.ImageList = ImageList;
			SaveButton.Location = new System.Drawing.Point(418, 104);
			SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new System.Drawing.Size(79, 29);
			SaveButton.TabIndex = 84;
			SaveButton.Text = "Save";
			SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click;
			// 
			// SettingsForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(603, 151);
			Controls.Add(CancelButton);
			Controls.Add(SaveButton);
			Controls.Add(StartFfmpegMinimizedCheckBox);
			Controls.Add(BrowseDefaultDirectoryButton);
			Controls.Add(DefaultDirectoryTextBox);
			Controls.Add(label1);
			Controls.Add(BrowseFfmpegExePathButton);
			Controls.Add(FfmpegExePathTextBox);
			Controls.Add(label3);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Name = "SettingsForm";
			Text = "FFmpeg Launcher: Settings";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox FfmpegExePathTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BrowseFfmpegExePathButton;
		private System.Windows.Forms.ImageList ImageList;
		private System.Windows.Forms.Button BrowseDefaultDirectoryButton;
		private System.Windows.Forms.TextBox DefaultDirectoryTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox StartFfmpegMinimizedCheckBox;
		new private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ToolTip ToolTip;
	}
}