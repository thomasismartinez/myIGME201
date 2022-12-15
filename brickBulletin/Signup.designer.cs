namespace brickBulletin
{
    partial class Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox1 = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.passTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.reenterErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.unErrorLabel = new System.Windows.Forms.Label();
            this.pwErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reenterErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up!";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(12, 97);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(251, 16);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Please enter the Username that you want:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(12, 180);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(249, 16);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Please enter the Password that you want:";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(194, 365);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(95, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(108, 130);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(165, 22);
            this.userTextBox.TabIndex = 4;
            // 
            // passTextBox1
            // 
            this.passTextBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox1.Location = new System.Drawing.Point(108, 211);
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.Size = new System.Drawing.Size(165, 22);
            this.passTextBox1.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(93, 365);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // passTextBox2
            // 
            this.passTextBox2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox2.Location = new System.Drawing.Point(108, 295);
            this.passTextBox2.Name = "passTextBox2";
            this.passTextBox2.Size = new System.Drawing.Size(165, 22);
            this.passTextBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please re-enter that Password:";
            // 
            // userErrorProvider
            // 
            this.userErrorProvider.ContainerControl = this;
            // 
            // passErrorProvider
            // 
            this.passErrorProvider.ContainerControl = this;
            // 
            // reenterErrorProvider
            // 
            this.reenterErrorProvider.ContainerControl = this;
            // 
            // unErrorLabel
            // 
            this.unErrorLabel.AutoSize = true;
            this.unErrorLabel.Location = new System.Drawing.Point(292, 135);
            this.unErrorLabel.Name = "unErrorLabel";
            this.unErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.unErrorLabel.TabIndex = 9;
            // 
            // pwErrorLabel
            // 
            this.pwErrorLabel.AutoSize = true;
            this.pwErrorLabel.Location = new System.Drawing.Point(295, 211);
            this.pwErrorLabel.Name = "pwErrorLabel";
            this.pwErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.pwErrorLabel.TabIndex = 10;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 413);
            this.Controls.Add(this.pwErrorLabel);
            this.Controls.Add(this.unErrorLabel);
            this.Controls.Add(this.passTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Sign Up Page";
            ((System.ComponentModel.ISupportInitialize)(this.userErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reenterErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox passTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider userErrorProvider;
        private System.Windows.Forms.ErrorProvider passErrorProvider;
        private System.Windows.Forms.ErrorProvider reenterErrorProvider;
        private System.Windows.Forms.Label pwErrorLabel;
        private System.Windows.Forms.Label unErrorLabel;
    }
}