using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brickBulletin
{
    public partial class PostCreationForm : Form
    {
        private Post post;
        public PostCreationForm()
        {
            InitializeComponent();
            this.realCancelButton.Click += new EventHandler(CancelButton__Clicked);

            this.realPostButton.Click += new EventHandler(PostButton__Clicked);
        }

        private void CancelButton__Clicked(object sender, EventArgs e)
        {
            PostDialogue postDialog = new PostDialogue();

            if (postDialog.ShowDialog(this) == DialogResult.OK)
            {
                postDialog.Dispose();
                this.Close();
            }
            else
            {
                postDialog.Dispose();
            }
            
        }

        private void PostButton__Clicked(object sender, EventArgs e)
        {
            // Create post
            post = new Post(Program.currentUser.name, headingTextBox.Text, bodyTextBox.Text, DateTime.Now);

            // Eventually push "post" onto user's post array
            Program.currentUser.posts.Add(post);

            // Close form
            this.Close();
        }

    }
   
}
