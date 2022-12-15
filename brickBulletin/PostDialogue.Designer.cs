namespace brickBulletin
{
    partial class PostDialogue
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelPostButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(59, 37);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(156, 25);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Are You Sure?";
            this.headingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "The current heading and body content will be lost.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelPostButton
            // 
            this.cancelPostButton.Location = new System.Drawing.Point(157, 159);
            this.cancelPostButton.Name = "cancelPostButton";
            this.cancelPostButton.Size = new System.Drawing.Size(75, 23);
            this.cancelPostButton.TabIndex = 2;
            this.cancelPostButton.Text = "Cancel Post";
            this.cancelPostButton.UseVisualStyleBackColor = true;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(37, 159);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            // 
            // PostDialogue
            // 
            this.AcceptButton = this.cancelPostButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.goBackButton;
            this.ClientSize = new System.Drawing.Size(270, 224);
            this.ControlBox = false;
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.cancelPostButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headingLabel);
            this.Name = "PostDialogue";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelPostButton;
        private System.Windows.Forms.Button goBackButton;
    }
}