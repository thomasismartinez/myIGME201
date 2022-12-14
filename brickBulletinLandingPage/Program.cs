using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace brickBulletinLandingPage
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        // Sorted List of All Groups that can post
        public static SortedList<string, User> groups = new SortedList<string, User>();

        // Sorted List of All General users
        public static SortedList<string, User> users = new SortedList<string, User>();

        // currently logged in user
        public static User currentUser;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }

    //Post Data Structure
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

    // User Data Structure
    public struct User
    {
        public User(string un, string pw, bool v)
        {
            this.name = un;
            this.password = pw;
            this.verified = v;
            this.posts = new List<Post>();
            this.followedUsers = new List<User>();

            // RIT should be the first group created since it has to be followed by default
            if (this.name != "RIT")
            {
                this.followedUsers.Add(Program.groups["RIT"]);
            }

            // add to correct list
            if (this.verified)
            {
                Program.groups.Add(name, this);
            }
            else
            {
                Program.users.Add(name, this);
            }
        }
        public string name { get; }
        public string password { get; set; }
        public bool verified { get; }
        public List<Post> posts { get; }
        public List<User> followedUsers { get; }
    }
}
