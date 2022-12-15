namespace brickBulletin
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            // this.directorySearcher = new System.DirectoryServices.DirectorySearcher();
            this.searchKeyText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResults = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.RITLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchKeyText
            // 
            this.searchKeyText.Location = new System.Drawing.Point(140, 100);
            this.searchKeyText.Name = "searchKeyText";
            this.searchKeyText.Size = new System.Drawing.Size(264, 20);
            this.searchKeyText.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(227, 154);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchResults
            // 
            this.searchResults.AutoSize = true;
            this.searchResults.Location = new System.Drawing.Point(137, 229);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(82, 13);
            this.searchResults.TabIndex = 2;
            this.searchResults.Text = "Search Results:";
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(0, -1);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            this.splitContainer.Panel1.Controls.Add(this.RITLabel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.searchResults);
            this.splitContainer.Panel2.Controls.Add(this.searchKeyText);
            this.splitContainer.Panel2.Controls.Add(this.searchButton);
            this.splitContainer.Size = new System.Drawing.Size(802, 451);
            this.splitContainer.SplitterDistance = 237;
            this.splitContainer.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(40, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(152, 146);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // RITLabel
            // 
            this.RITLabel.AutoSize = true;
            this.RITLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RITLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RITLabel.Location = new System.Drawing.Point(58, 180);
            this.RITLabel.Name = "RITLabel";
            this.RITLabel.Size = new System.Drawing.Size(134, 22);
            this.RITLabel.TabIndex = 0;
            this.RITLabel.Text = "Brick Bulletin";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // private System.DirectoryServices.DirectorySearcher directorySearcher;
        private System.Windows.Forms.TextBox searchKeyText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResults;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label RITLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

