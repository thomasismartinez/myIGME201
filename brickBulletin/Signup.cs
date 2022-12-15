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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

            this.createButton.Click += new EventHandler(CreateButton__Click);
            this.cancelButton.Click += new EventHandler(CancelButton__Click);
        }

        private void CreateButton__Click(object sender, EventArgs e)
        {
            pwErrorLabel.Visible = false;
            unErrorLabel.Visible = false;
            if (!Program.groups.ContainsKey(this.userTextBox.Text))
            {
                if (this.userTextBox.Text.Length < 20)
                {
                    if (this.passTextBox1.Text == this.passTextBox2.Text)
                    {
                        User newUser = new User(this.userTextBox.Text, this.passTextBox1.Text, false);
                        this.Hide();
                    }
                    else
                    {
                        pwErrorLabel.Text = "passwords don't match";
                        pwErrorLabel.Visible = true;
                    }
                }
                else
                {
                    unErrorLabel.Text = "Username too long";
                    unErrorLabel.Visible = true;
                }
            }
            else
            {
                unErrorLabel.Text = "Username taken";
                unErrorLabel.Visible = true;
            }
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
