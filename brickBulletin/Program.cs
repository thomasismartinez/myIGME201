using brickBulletin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brickBulletin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //Colors
        public static Color BackColor = Color.FromArgb(255, 255, 255);
        public static Color ForeColor = Color.FromArgb(00, 00, 00);

        //Font Size
        public static int normalSize = Convert.ToInt32(8.25);
        public static int homepageSize = Convert.ToInt32(7.8);
        public static int postDialogueSize = Convert.ToInt32(9.75);
        public static int postCreationSize = Convert.ToInt32(12);

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

            // if not guest
            if (name != "Guest")
            {
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
        }
        public string name { get; }
        public string password { get; set; }
        public bool verified { get; }
        public List<Post> posts { get; }
        public List<User> followedUsers { get; }
    }
}
