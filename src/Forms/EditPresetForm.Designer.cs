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
			OverrideExistingCheckbox = new System.Windows.Forms.CheckBox();
			CancelButton = new System.Windows.Forms.Button();
			AddButton = new System.Windows.Forms.Button();
			PresetNameLabel = new System.Windows.Forms.Label();
			PresetNameTextBox = new System.Windows.Forms.TextBox();
			SuspendLayout();
			// 
			// OverrideExistingCheckbox
			// 
			OverrideExistingCheckbox.AutoSize = true;
			OverrideExistingCheckbox.Checked = true;
			OverrideExistingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			OverrideExistingCheckbox.Location = new System.Drawing.Point(12, 62);
			OverrideExistingCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			OverrideExistingCheckbox.Name = "OverrideExistingCheckbox";
			OverrideExistingCheckbox.Size = new System.Drawing.Size(115, 19);
			OverrideExistingCheckbox.TabIndex = 9;
			OverrideExistingCheckbox.Text = "Override existing";
			OverrideExistingCheckbox.UseVisualStyleBackColor = true;
			OverrideExistingCheckbox.CheckedChanged += OverrideExistingCheckbox_CheckedChanged;
			// 
			// CancelButton
			// 
			CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			CancelButton.Location = new System.Drawing.Point(274, 56);
			CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new System.Drawing.Size(75, 23);
			CancelButton.TabIndex = 8;
			CancelButton.Text = "Cancel";
			CancelButton.UseVisualStyleBackColor = true;
			// 
			// AddButton
			// 
			AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			AddButton.Location = new System.Drawing.Point(274, 27);
			AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			AddButton.Name = "AddButton";
			AddButton.Size = new System.Drawing.Size(75, 23);
			AddButton.TabIndex = 7;
			AddButton.Text = "Add";
			AddButton.UseVisualStyleBackColor = true;
			AddButton.Click += AddButton_Click;
			// 
			// PresetNameLabel
			// 
			PresetNameLabel.AutoSize = true;
			PresetNameLabel.Location = new System.Drawing.Point(9, 13);
			PresetNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			PresetNameLabel.Name = "PresetNameLabel";
			PresetNameLabel.Size = new System.Drawing.Size(42, 15);
			PresetNameLabel.TabIndex = 6;
			PresetNameLabel.Text = "Name:";
			// 
			// PresetNameTextBox
			// 
			PresetNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			PresetNameTextBox.Location = new System.Drawing.Point(12, 29);
			PresetNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			PresetNameTextBox.MaxLength = 256;
			PresetNameTextBox.Name = "PresetNameTextBox";
			PresetNameTextBox.Size = new System.Drawing.Size(243, 23);
			PresetNameTextBox.TabIndex = 5;
			// 
			// EditPresetForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(359, 93);
			Controls.Add(OverrideExistingCheckbox);
			Controls.Add(CancelButton);
			Controls.Add(AddButton);
			Controls.Add(PresetNameLabel);
			Controls.Add(PresetNameTextBox);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "EditPresetForm";
			Text = "FFmpeg Launcher: New preset";
			TopMost = true;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		internal System.Windows.Forms.CheckBox OverrideExistingCheckbox;
		private new System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Label PresetNameLabel;
		internal System.Windows.Forms.TextBox PresetNameTextBox;
	}
}