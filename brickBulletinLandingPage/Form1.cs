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
        public HomeForm()
        {
            InitializeComponent();
            feed.Add(new Post("Thomas Martinez", "TESTING", "THIS IS A TEST POST",new DateTime(12,1,22) ));
        }
    }
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
}
