using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

// Thomas Martinez

namespace brickBulletin
{
    public partial class HomeForm : Form
    {
        private List<Post> feed;
        private string currentGroupPage;

        public string currentPage;
        public HomeForm()
        {
            InitializeComponent();

            //Demonstrational Code//
            User user = new User("RIT", "pw", true);

            // test user
            User viewer = new User("viewerTest", "vtPW", false);
            User poster = new User("posterTest", "ptPW", true);

            user = new User("Thomas Martinez", "pw", true);
            viewer.followedUsers.Add(user);
            user = new User("WITR", "pw", true);
            viewer.followedUsers.Add(user);
            user = new User("Launch Initiative", "pw", true);
            viewer.followedUsers.Add(user);
            user = new User("RIT Dining", "pw", true);

            // create posts
            Post post = new Post("RIT", "Catalytic Converter Thefts", "somebody is still stealing catalytic converters" +
                " around campus.", new DateTime(2022,10,29));
            Program.groups["RIT"].posts.Add(post);
            post = new Post("RIT", "Lithium Ion Battery Fire", "somebody is still blowing up Lithium Ion Batteries" +
                " around.", new DateTime(2022, 11, 1));
            Program.groups["RIT"].posts.Add(post);
            post = new Post("Thomas Martinez", "HELLO", "This is the first thing ever posted to Brick Bulletin", new DateTime(1, 1, 1));
            Program.groups["Thomas Martinez"].posts.Add(post);
            post = new Post("WITR", "College Radio Day", "College radio day is coming up! Stop by GV to hang out and listen!", new DateTime(2012, 2, 13));
            Program.groups["WITR"].posts.Add(post);
            post = new Post("Launch Initiative", "ROCKETS", "We shoot things at the sky come join us!", new DateTime(2019, 4, 12));
            Program.groups["Launch Initiative"].posts.Add(post);
            post = new Post("WITR", "DJ Training", "First Round of DJ training is tomorrow", new DateTime(2023, 2, 13));
            Program.groups["WITR"].posts.Add(post);
            post = new Post("RIT Dining", "Locations closing", "Starting the 14th of December all RIT Dining locations " +
                "will be closed until the 16th of Janurary.", new DateTime(2022, 12, 10));
            Program.groups["RIT Dining"].posts.Add(post);
            post = new Post("RIT Dining", "Locations opening", "Starting the 16th of December all RIT Dining locations " +
                "will be openong again until the 16th of Janurary.", new DateTime(2023, 1, 10));
            Program.groups["RIT Dining"].posts.Add(post);

            //Demonstrational Code//

            // Button Event Handlers
            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.searchButton.Click += new EventHandler(SearchButton__Click);
            this.settingsButton.Click += new EventHandler(SettingsButton__Click);
            this.createPostButton.Click += new EventHandler(CreatePostButton__Click);
            this.refreshButton.Click += new EventHandler(RefreshButton__Click);
            this.followButton.Click += new EventHandler(FollowButton__Click);
            this.homeButton.Click += new EventHandler(HomeButton__Click);

            //feedFlowLayoutPanel change size
            this.feedFlowLayoutPanel.SizeChanged += new EventHandler(FeedFlowLayoutPanel__SizeChanged);

            // Generate default to logged-out view
            // guest user
            User guest = new User("Guest", "", false);
            Program.currentUser = guest;

            RefreshFeed();
            RefreshFilters();
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

        public void RefreshFilters()
        {
            this.filterFlowLayoutPanel.Controls.Clear();

            foreach (User fUser in Program.currentUser.followedUsers)
            {
                // Add filter buttons
                GenerateFilterControl(fUser.name);
            }
        }

        // Fill/Refresh feedFlowLayoutBox with up to date posts
        public void RefreshFeed()
        {
            // Clear feed
            this.feedFlowLayoutPanel.Controls.Clear();

            feed = new List<Post>();
            IEnumerable<Post> sortedPosts = new List<Post>();

            // check if there is an active page
            if (currentPage != null)
            {
                this.pageLabel.Text = currentPage;
                feed = Program.groups[currentPage].posts;
                if (Program.currentUser.name != "Guest")
                {
                    this.followButton.Visible = true;
                }
            }
            // otherwise homepage
            else
            {
                this.pageLabel.Text = "Home";
                this.followButton.Visible = false;
                foreach (User fUser in Program.currentUser.followedUsers)
                {
                    sortedPosts.Concat(fUser.posts);
                    feed.AddRange(fUser.posts);
                }
                
            }

            // Add all post by fUser to sortedPosts in order of date
            sortedPosts = (this.feed.OrderBy(x => x.created)).Reverse();

            // Populate feed with posts from allPosts that meet filter requirements
            foreach (Post p in sortedPosts)
            {
                GeneratePostControl(p);
            }

            foreach (Control c in feedFlowLayoutPanel.Controls)
            {
                c.ForeColor = Program.ForeColor;
                c.BackColor = Program.BackColor;
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
            Login lf = new Login();
            lf.ShowDialog();

            this.userLabel.Text = "Currently Logged In As: " + Program.currentUser.name;

            if (Program.currentUser.verified)
            {
                this.createPostButton.Visible = true;
            }
            else
            {
                this.createPostButton.Visible = false;
            }

            RefreshFeed();
            RefreshFilters();
        }
        private void SearchButton__Click(object sender, EventArgs e)
        {
            // Open Search Form
            this.currentPage = null;
            SearchForm sf = new SearchForm(this);
            sf.ShowDialog();

            if (this.currentPage != null)
            {
                RefreshFeed();
            }
        }
        private void SettingsButton__Click(object sender, EventArgs e)
        {
            // Open Settings Form
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
            this.BackColor = Program.BackColor;
            this.ForeColor = Program.ForeColor;
            this.Font = new Font("Arial", Program.homepageSize, FontStyle.Regular);
            filterFlowLayoutPanel.BackColor = Program.BackColor;
            feedFlowLayoutPanel.BackColor = Program.BackColor;
            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                c.BackColor = Program.BackColor;
            }
            foreach (Control c in feedFlowLayoutPanel.Controls)
            {
                c.ForeColor = Program.ForeColor;
                c.BackColor = Program.BackColor;
            }
        }

        private void CreatePostButton__Click(object sender, EventArgs e)
        {
            // Open Create Post Form
            PostCreationForm pcf = new PostCreationForm();
            pcf.ShowDialog();
        }

        private void RefreshButton__Click(object sender, EventArgs e)
        {
            // Refresh Feed
            RefreshFeed();
        }

        private void FollowButton__Click(object sender, EventArgs e)
        {
            // Follow groups that is currently being viewed
            if (Program.groups.ContainsKey(this.currentPage))
            {
                Program.currentUser.followedUsers.Add(Program.groups[this.currentPage]);
            }
        }

        private void HomeButton__Click(object sender, EventArgs e)
        {
            this.currentPage = null;
            RefreshFeed();
        }

        // Filter Buttons
        private void FilterButton__Click(object sender, EventArgs e)
        {
            Button fb = (Button)sender;

            foreach (Button b in this.filterFlowLayoutPanel.Controls)
            {
                if (b.Text == fb.Text)
                {
                    if (currentPage == fb.Text)
                    {
                        this.currentPage = null;
                        fb.BackColor = Color.LightGray;
                        fb.ForeColor = Program.ForeColor;
                    }
                    else
                    {
                        this.currentPage = fb.Text;
                        fb.BackColor = Color.FromArgb(247, 105, 2);
                        fb.ForeColor = Color.Black;
                    }
                }
                else
                {
                    b.BackColor = Color.LightGray;
                }
            }

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
