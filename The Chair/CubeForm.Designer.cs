namespace The_Chair
{
    partial class CubeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubeForm));
            this.qLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wordResponseTextBox = new System.Windows.Forms.TextBox();
            this.responseLabel = new System.Windows.Forms.Label();
            this.rightWrongLabel = new System.Windows.Forms.Label();
            this.qOutbputLabel = new System.Windows.Forms.Label();
            this.submitWordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qLabel.Location = new System.Drawing.Point(206, 26);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(105, 31);
            this.qLabel.TabIndex = 0;
            this.qLabel.Text = "Question:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // wordResponseTextBox
            // 
            this.wordResponseTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wordResponseTextBox.Enabled = false;
            this.wordResponseTextBox.Location = new System.Drawing.Point(0, 283);
            this.wordResponseTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wordResponseTextBox.Name = "wordResponseTextBox";
            this.wordResponseTextBox.Size = new System.Drawing.Size(666, 28);
            this.wordResponseTextBox.TabIndex = 2;
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseLabel.Location = new System.Drawing.Point(12, 247);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(86, 31);
            this.responseLabel.TabIndex = 3;
            this.responseLabel.Text = "Answer:";
            this.responseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightWrongLabel
            // 
            this.rightWrongLabel.AutoSize = true;
            this.rightWrongLabel.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightWrongLabel.Location = new System.Drawing.Point(378, 224);
            this.rightWrongLabel.Name = "rightWrongLabel";
            this.rightWrongLabel.Size = new System.Drawing.Size(87, 28);
            this.rightWrongLabel.TabIndex = 4;
            this.rightWrongLabel.Text = "RIGHT";
            this.rightWrongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightWrongLabel.Visible = false;
            // 
            // qOutbputLabel
            // 
            this.qOutbputLabel.AutoSize = true;
            this.qOutbputLabel.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qOutbputLabel.Location = new System.Drawing.Point(234, 112);
            this.qOutbputLabel.Name = "qOutbputLabel";
            this.qOutbputLabel.Size = new System.Drawing.Size(21, 27);
            this.qOutbputLabel.TabIndex = 5;
            this.qOutbputLabel.Text = "q";
            this.qOutbputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitWordButton
            // 
            this.submitWordButton.Enabled = false;
            this.submitWordButton.Location = new System.Drawing.Point(591, 253);
            this.submitWordButton.Name = "submitWordButton";
            this.submitWordButton.Size = new System.Drawing.Size(75, 23);
            this.submitWordButton.TabIndex = 6;
            this.submitWordButton.Text = "enter";
            this.submitWordButton.UseVisualStyleBackColor = true;
            // 
            // CubeForm
            // 
            this.AcceptButton = this.submitWordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 311);
            this.ControlBox = false;
            this.Controls.Add(this.submitWordButton);
            this.Controls.Add(this.qOutbputLabel);
            this.Controls.Add(this.rightWrongLabel);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.wordResponseTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.qLabel);
            this.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CubeForm";
            this.Text = "The Cube";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox wordResponseTextBox;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.Label rightWrongLabel;
        private System.Windows.Forms.Label qOutbputLabel;
        private System.Windows.Forms.Button submitWordButton;
    }
}