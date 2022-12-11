using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brickBulletinLandingPage
{
    public partial class HomeForm : Form
    {
        private string currentUser;
        public SortedList<string, string> userList;
        public List<string> verifiedUsers = new List<string>();
        private List<Post> feed = new List<Post>();
        private List<string> filteredUsers = new List<string>();
        private List<string> followedUsers = new List<string>();

        public Color[] pallete = new Color[3] {Color.Red, Color.Red, Color.Red};
        public HomeForm()
        {
            InitializeComponent();

            //TEST//
            Post post = new Post("Rochester Institute of Technology", "Catalytic Converter Thefts", "somebody is still stealing catalytic converters" +
                " around campus.", new DateTime(2022,10,29));
            GeneratePostControl(post);
            feed.Add(post);
            post = new Post("Rochester Institute of Technology", "Lithium Ion Battery Fire", "somebody is still blowing up Lithium Ion Batteries" +
                " around.", new DateTime(2022, 11, 1));
            GeneratePostControl(post);
            feed.Add(post);
            //TEST//

            // Button Event Handlers
            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.searchButton.Click += new EventHandler(SearchButton__Click);
            this.settingsButton.Click += new EventHandler(SettingsButton__Click);
            this.createPostButton.Click += new EventHandler(CreatePostButton__Click);
            this.refreshButton.Click += new EventHandler(RefreshButton__Click);
            this.followButton.Click += new EventHandler(FollowButton__Click);

            //feedFlowLayoutPanel change size
            this.feedFlowLayoutPanel.SizeChanged += new EventHandler(FeedFlowLayoutPanel__SizeChanged);

            // Generate default to logged-out view

            // RIT filter
            GenerateFilterControl("Rochester Institute of Technology");

            // 
            followedUsers.Add("Rochester Institute of Technology");
        }

        // Data structure for storing post information
        public struct Post
        {
            public Post(string c, string t, string b, DateTime d)
            {
                this.creator = c;
                this.title = t;
                this.body = b;
                this.created = d;
            }
            public string creator { get; }
            public string title { get; }
            public string body { get; }
            public DateTime created { get; }
        }

        // Create post control and add it to feed
        public void GeneratePostControl(Post post)
        {
            // create groupBox
            GroupBox postBox = new GroupBox();
            postBox.Text = post.creator + " | " + post.created.ToString();
            //postBox.Width = 630;
            postBox.Width = feedFlowLayoutPanel.Width - 10;
            postBox.BackColor = Color.LightGray;
            postBox.SizeChanged += new EventHandler(PostGroupBox__SizeChanged);

            // title text
            Label title = new Label();
            title.Text = post.title;
            title.Location = new Point(10, 20);
            title.Height = 20;
            title.Width = postBox.Width;
            postBox.Controls.Add(title);

            // body text
            Label body = new Label();
            body.Text = post.body;
            body.Location = new Point(10, 40);
            body.Height = 50;
            body.Width = postBox.Width;
            postBox.Controls.Add(body);

            // add postBos to feed
            this.feedFlowLayoutPanel.Controls.Add(postBox);
        }

        // Add verified user filter button
        public void GenerateFilterControl(string poster)
        {
            Button filterButton = new Button();
            filterButton.Text = poster;
            filterButton.Size = new Size(100, 50);
            filterButton.Margin = new Padding(0);
            filterButton.Click += new EventHandler(FilterButton__Click);
            filterFlowLayoutPanel.Controls.Add(filterButton);
        }

        // Fill/Refresh feedFlowLayoutBox with up to date posts
        public void RefreshFeed()
        {
            IEnumerable<Post> sortedPosts = new List<Post>();
            foreach (string fUser in followedUsers)
            {
                // Add all post by fUser to allPosts in order of date
                sortedPosts = (this.feed.OrderBy( x => x.created)).Reverse();
            }

            // Clear feed
            this.feedFlowLayoutPanel.Controls.Clear();

            // Populate feed with posts from allPosts that meet filter requirements
            foreach (Post p in sortedPosts)
            {
                if (this.filteredUsers.Contains(p.creator) || this.filteredUsers.Count == 0 )
                {
                    GeneratePostControl(p);
                }
            }
        }

        /*
         * -----------------------------------------------------------------------------------------------------------------------------------------
         * | EVENT HANDLERS | EVENT HANDLERS | EVENT HANDLERS | EVENT HANDLERS | EVENT HANDLERS | EVENT HANDLERS | EVENT HANDLERS | EVENT HANDLERS |
         * -----------------------------------------------------------------------------------------------------------------------------------------
         */

        private void LoginButton__Click(object sender, EventArgs e)
        {
            Button lib =(Button)sender;
            // Open Login Form

            // Demonstrational
            if (lib.Text != "tjm7126")
            {
                Post post = new Post("Thomas Martinez", "HELLO", "This is the first thing ever posted to Brick Bulletin", new DateTime(1, 1, 1));
                GeneratePostControl(post);
                feed.Add(post);
                post = new Post("WITR", "College Radio Day", "College radio day is coming up! Stop by GV to hang out and listen!", new DateTime(2012, 2, 13));
                GeneratePostControl(post);
                feed.Add(post);
                post = new Post("Launch Initiative", "ROCKETS", "We shoot things at the sky come join us!", new DateTime(2019, 4, 12));
                GeneratePostControl(post);
                feed.Add(post);
                post = new Post("WITR", "DJ Training", "First Round of DJ training is tomorrow", new DateTime(2023, 2, 13));
                GeneratePostControl(post);
                feed.Add(post);
                GenerateFilterControl("Thomas Martinez");
                GenerateFilterControl("Launch Initiative");
                GenerateFilterControl("WITR");
                createPostButton.Visible = true;
            }

            lib.Text = "tjm7126";
        }
        private void SearchButton__Click(object sender, EventArgs e)
        {
            // Open Search Form
        }
        private void SettingsButton__Click(object sender, EventArgs e)
        {
            // Open Settings Form
        }

        private void CreatePostButton__Click(object sender, EventArgs e)
        {
            // Open Create Post Form
        }

        private void RefreshButton__Click(object sender, EventArgs e)
        {
            // Refresh Feed
            RefreshFeed();
        }

        private void FollowButton__Click(object sender, EventArgs e)
        {
            // Follow groups that is currently being viewed
        }

        // Filter Buttons
        private void FilterButton__Click(object sender, EventArgs e)
        {
            Button fb = (Button)sender;


            string userFilter = fb.Text;
            if (this.filteredUsers.Contains(userFilter))
            {
                this.filteredUsers.Remove(fb.Text);
                fb.BackColor = Color.LightGray;
            }
            else
            {
                this.filteredUsers.Add(fb.Text);
                fb.BackColor = Color.FromArgb(247, 105, 2);

            }

            List<string> test = filteredUsers;

            RefreshFeed();
        }

        private void FeedFlowLayoutPanel__SizeChanged(object sender, EventArgs e)
        {
            this.feedFlowLayoutPanel.SuspendLayout();
            foreach (GroupBox gb in this.feedFlowLayoutPanel.Controls)
            {
                gb.Width = this.feedFlowLayoutPanel.ClientSize.Width - 10;
            }
            this.feedFlowLayoutPanel.ResumeLayout();
        }
        private void PostGroupBox__SizeChanged(object sender, EventArgs e)
        {
            GroupBox gb = (GroupBox)sender;
            //change width of title and body text to fit container
            //((Label)gb.Controls.Find("body", true)[0]).Width = gb.Width;
            //((Label)gb.Controls.Find("title", true)[0]).Width = gb.Width;
        }
    }
}
