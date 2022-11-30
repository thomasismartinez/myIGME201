namespace The_Chair
{
    partial class SmashForm
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
            this.smashButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smashButton
            // 
            this.smashButton.Location = new System.Drawing.Point(25, 25);
            this.smashButton.Name = "smashButton";
            this.smashButton.Size = new System.Drawing.Size(139, 65);
            this.smashButton.TabIndex = 0;
            this.smashButton.Text = "Smash The Chair With a Hammer";
            this.smashButton.UseVisualStyleBackColor = true;
            // 
            // SmashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 114);
            this.ControlBox = false;
            this.Controls.Add(this.smashButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SmashForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button smashButton;
    }
}