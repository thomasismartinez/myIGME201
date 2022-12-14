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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.createPostButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.userLabel = new System.Windows.Forms.Label();
            this.followButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.filterFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.feedFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(174, 119);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(270, 54);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 36);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // createPostButton
            // 
            this.createPostButton.Location = new System.Drawing.Point(361, 12);
            this.createPostButton.Name = "createPostButton";
            this.createPostButton.Size = new System.Drawing.Size(109, 36);
            this.createPostButton.TabIndex = 3;
            this.createPostButton.Text = "+ Create Post";
            this.createPostButton.UseVisualStyleBackColor = true;
            this.createPostButton.Visible = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(179, 54);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(85, 36);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(270, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(85, 36);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(179, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(85, 36);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.userLabel);
            this.splitContainer1.Panel1.Controls.Add(this.followButton);
            this.splitContainer1.Panel1.Controls.Add(this.refreshButton);
            this.splitContainer1.Panel1.Controls.Add(this.loginButton);
            this.splitContainer1.Panel1.Controls.Add(this.logoPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.settingsButton);
            this.splitContainer1.Panel1.Controls.Add(this.createPostButton);
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(872, 542);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 11;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(558, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(181, 16);
            this.userLabel.TabIndex = 11;
            this.userLabel.Text = "Currently Logged In As: Guest";
            // 
            // followButton
            // 
            this.followButton.Location = new System.Drawing.Point(361, 54);
            this.followButton.Name = "followButton";
            this.followButton.Size = new System.Drawing.Size(109, 36);
            this.followButton.TabIndex = 10;
            this.followButton.Text = "Follow Group";
            this.followButton.UseVisualStyleBackColor = true;
            this.followButton.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.filterFlowLayoutPanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.feedFlowLayoutPanel);
            this.splitContainer2.Size = new System.Drawing.Size(872, 419);
            this.splitContainer2.SplitterDistance = 136;
            this.splitContainer2.TabIndex = 8;
            // 
            // filterFlowLayoutPanel
            // 
            this.filterFlowLayoutPanel.AutoScroll = true;
            this.filterFlowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.filterFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.filterFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.filterFlowLayoutPanel.Name = "filterFlowLayoutPanel";
            this.filterFlowLayoutPanel.Size = new System.Drawing.Size(136, 419);
            this.filterFlowLayoutPanel.TabIndex = 7;
            this.filterFlowLayoutPanel.WrapContents = false;
            // 
            // feedFlowLayoutPanel
            // 
            this.feedFlowLayoutPanel.AutoScroll = true;
            this.feedFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.feedFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.feedFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.feedFlowLayoutPanel.Name = "feedFlowLayoutPanel";
            this.feedFlowLayoutPanel.Size = new System.Drawing.Size(732, 419);
            this.feedFlowLayoutPanel.TabIndex = 6;
            this.feedFlowLayoutPanel.WrapContents = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 542);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomeForm";
            this.Text = "Brick Bulletin";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button createPostButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel filterFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel feedFlowLayoutPanel;
        private System.Windows.Forms.Button followButton;
        private System.Windows.Forms.Label userLabel;
    }
}

