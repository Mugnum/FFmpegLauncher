namespace Mugnum.FFmpegLauncher.Forms
{
	partial class EditPresetForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPresetForm));
			this.OverrideExistingCheckbox = new System.Windows.Forms.CheckBox();
			this.CancelButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.PresetNameLabel = new System.Windows.Forms.Label();
			this.PresetNameTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// OverrideExistingCheckbox
			// 
			this.OverrideExistingCheckbox.AutoSize = true;
			this.OverrideExistingCheckbox.Checked = true;
			this.OverrideExistingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.OverrideExistingCheckbox.Location = new System.Drawing.Point(12, 62);
			this.OverrideExistingCheckbox.Name = "OverrideExistingCheckbox";
			this.OverrideExistingCheckbox.Size = new System.Drawing.Size(104, 17);
			this.OverrideExistingCheckbox.TabIndex = 9;
			this.OverrideExistingCheckbox.Text = "Override existing";
			this.OverrideExistingCheckbox.UseVisualStyleBackColor = true;
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(274, 56);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 8;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AddButton.Location = new System.Drawing.Point(274, 27);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 7;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// PresetNameLabel
			// 
			this.PresetNameLabel.AutoSize = true;
			this.PresetNameLabel.Location = new System.Drawing.Point(9, 13);
			this.PresetNameLabel.Name = "PresetNameLabel";
			this.PresetNameLabel.Size = new System.Drawing.Size(38, 13);
			this.PresetNameLabel.TabIndex = 6;
			this.PresetNameLabel.Text = "Name:";
			// 
			// PresetNameTextBox
			// 
			this.PresetNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PresetNameTextBox.Location = new System.Drawing.Point(12, 29);
			this.PresetNameTextBox.MaxLength = 256;
			this.PresetNameTextBox.Name = "PresetNameTextBox";
			this.PresetNameTextBox.Size = new System.Drawing.Size(243, 20);
			this.PresetNameTextBox.TabIndex = 5;
			// 
			// EditPresetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 93);
			this.Controls.Add(this.OverrideExistingCheckbox);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.PresetNameLabel);
			this.Controls.Add(this.PresetNameTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditPresetForm";
			this.Text = "FFmpeg Launcher: New preset";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.CheckBox OverrideExistingCheckbox;
		private new System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Label PresetNameLabel;
		internal System.Windows.Forms.TextBox PresetNameTextBox;
	}
}