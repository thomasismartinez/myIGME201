namespace brickBulletinLandingPage
{
    partial class HomeForm
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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.createPostButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.feedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(148, 78);
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(575, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // createPostButton
            // 
            this.createPostButton.Location = new System.Drawing.Point(204, 51);
            this.createPostButton.Name = "createPostButton";
            this.createPostButton.Size = new System.Drawing.Size(103, 23);
            this.createPostButton.TabIndex = 3;
            this.createPostButton.Text = "Create Post";
            this.createPostButton.UseVisualStyleBackColor = true;
            this.createPostButton.Visible = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(941, 82);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(941, 22);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // feedFlowLayoutPanel
            // 
            this.feedFlowLayoutPanel.AutoScroll = true;
            this.feedFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.feedFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.feedFlowLayoutPanel.Location = new System.Drawing.Point(166, 111);
            this.feedFlowLayoutPanel.Name = "feedFlowLayoutPanel";
            this.feedFlowLayoutPanel.Size = new System.Drawing.Size(850, 450);
            this.feedFlowLayoutPanel.TabIndex = 6;
            this.feedFlowLayoutPanel.WrapContents = false;
            // 
            // filterFlowLayoutPanel
            // 
            this.filterFlowLayoutPanel.AutoScroll = true;
            this.filterFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filterFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.filterFlowLayoutPanel.Location = new System.Drawing.Point(12, 111);
            this.filterFlowLayoutPanel.Name = "filterFlowLayoutPanel";
            this.filterFlowLayoutPanel.Size = new System.Drawing.Size(150, 450);
            this.filterFlowLayoutPanel.TabIndex = 7;
            this.filterFlowLayoutPanel.WrapContents = false;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(204, 22);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 569);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.filterFlowLayoutPanel);
            this.Controls.Add(this.feedFlowLayoutPanel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.createPostButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "HomeForm";
            this.Text = "Brick Bulletin - Home";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button createPostButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.FlowLayoutPanel feedFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel filterFlowLayoutPanel;
        private System.Windows.Forms.Button loginButton;
    }
}

