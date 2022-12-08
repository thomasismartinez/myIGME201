using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brickBulletinLandingPage
{
    public partial class HomeForm : Form
    {
        private List<Post> feed = new List<Post>();
        private List<string> followedUsers = new List<string>();
        public HomeForm()
        {
            InitializeComponent();
            feed.Add(new Post("Thomas Martinez", "TESTING", "THIS IS A TEST POST",new DateTime(12,1,22) ));

            //TEST//
            Post post = new Post("Rochester Institute of Technology", "Catalytic Converter Thefts", "some ass-hat is still steal catalytic converters" +
                "around camput and we still haven't done anything about it. ALSO FREEZE FEST IS BACK!!!", new DateTime(12,7,22));
            GeneratePostControl(post);

            for (int i = 0; i < 20; i++)
            {
                GenerateFilterControl(i.ToString());
            }

            //TEST//

            // Add default RIT filter
            GenerateFilterControl("RIT");
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
            postBox.Text = post.creator;
            postBox.Width = 630;

            // title text
            Label title = new Label();
            title.Text = post.title;
            title.Location = new Point(26, 22);
            postBox.Controls.Add(title);

            // date
            Label date = new Label();
            date.Text = post.created.ToString();
            date.Location = new Point(129, 22);
            postBox.Controls.Add(date);

            // body text
            Label body = new Label();
            body.Text = post.body;
            body.Location = new Point(65, 62);
            postBox.Controls.Add(body);

            // add postBos to feed
            this.feedFlowLayoutPanel.Controls.Add(postBox);
        }

        // Add verified user filter button
        public void GenerateFilterControl(string poster)
        {
            Button filterButton = new Button();
            filterButton.Text = poster;
            filterButton.Size = new Size(70, 30);
            filterFlowLayoutPanel.Controls.Add(filterButton);
        }

        // Fill/Refresg feedFlowLayoutBox with up to date posts
        public void RefrexhFeed(string user)
        {
            // Deserialize list of users

            // 

            List<Post> allPosts = new List<Post>();
            foreach (string fUser in followedUsers)
            {
                // Deserialize posts by fUser

                // Add all post by fUser to allPosts
            }

            // Populate feed with posts from allPosts
            while (allPosts.Count > 0)
            {

            }
        }
    }
}
