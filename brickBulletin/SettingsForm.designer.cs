namespace brickBulletin
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
            this.largeFontSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.darkThemeLabel = new System.Windows.Forms.Label();
            this.defaultFontSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.darkThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // largeFontSizeRadioButton
            // 
            this.largeFontSizeRadioButton.AutoSize = true;
            this.largeFontSizeRadioButton.Location = new System.Drawing.Point(36, 113);
            this.largeFontSizeRadioButton.Name = "largeFontSizeRadioButton";
            this.largeFontSizeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.largeFontSizeRadioButton.TabIndex = 4;
            this.largeFontSizeRadioButton.Text = "Large";
            this.largeFontSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fontSizeLabel.Location = new System.Drawing.Point(33, 70);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(58, 15);
            this.fontSizeLabel.TabIndex = 3;
            this.fontSizeLabel.Text = "Font Size";
            // 
            // darkThemeLabel
            // 
            this.darkThemeLabel.AutoSize = true;
            this.darkThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.darkThemeLabel.Location = new System.Drawing.Point(33, 20);
            this.darkThemeLabel.Name = "darkThemeLabel";
            this.darkThemeLabel.Size = new System.Drawing.Size(75, 15);
            this.darkThemeLabel.TabIndex = 2;
            this.darkThemeLabel.Text = "Dark Theme";
            // 
            // defaultFontSizeRadioButton
            // 
            this.defaultFontSizeRadioButton.AutoSize = true;
            this.defaultFontSizeRadioButton.Checked = true;
            this.defaultFontSizeRadioButton.Location = new System.Drawing.Point(36, 90);
            this.defaultFontSizeRadioButton.Name = "defaultFontSizeRadioButton";
            this.defaultFontSizeRadioButton.Size = new System.Drawing.Size(59, 17);
            this.defaultFontSizeRadioButton.TabIndex = 1;
            this.defaultFontSizeRadioButton.TabStop = true;
            this.defaultFontSizeRadioButton.Text = "Default";
            this.defaultFontSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // darkThemeCheckBox
            // 
            this.darkThemeCheckBox.AutoSize = true;
            this.darkThemeCheckBox.Location = new System.Drawing.Point(36, 40);
            this.darkThemeCheckBox.Name = "darkThemeCheckBox";
            this.darkThemeCheckBox.Size = new System.Drawing.Size(121, 17);
            this.darkThemeCheckBox.TabIndex = 0;
            this.darkThemeCheckBox.Text = "Enable Dark Theme";
            this.darkThemeCheckBox.UseVisualStyleBackColor = true;
            // 
            // settingsGroupBox
            // 
            //this.settingsGroupBox.BackgroundImage = global::brickBulletin.Properties.Resources.Roaring_Tiger_rgb_transluscent;
            this.settingsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsGroupBox.Controls.Add(this.largeFontSizeRadioButton);
            this.settingsGroupBox.Controls.Add(this.fontSizeLabel);
            this.settingsGroupBox.Controls.Add(this.darkThemeLabel);
            this.settingsGroupBox.Controls.Add(this.defaultFontSizeRadioButton);
            this.settingsGroupBox.Controls.Add(this.darkThemeCheckBox);
            this.settingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(241, 222);
            this.settingsGroupBox.TabIndex = 2;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 222);
            this.Controls.Add(this.settingsGroupBox);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton largeFontSizeRadioButton;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.Label darkThemeLabel;
        private System.Windows.Forms.RadioButton defaultFontSizeRadioButton;
        private System.Windows.Forms.CheckBox darkThemeCheckBox;
        private System.Windows.Forms.GroupBox settingsGroupBox;
    }
}