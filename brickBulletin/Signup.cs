using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Max Chu

namespace brickBulletin
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

            this.createButton.Click += new EventHandler(CreateButton__Click);
            this.cancelButton.Click += new EventHandler(CancelButton__Click);

            // style
            this.BackColor = Program.BackColor;
            this.ForeColor = Program.ForeColor;
            this.Font = new Font("Arial", Program.normalSize, FontStyle.Regular);
            foreach (Control c in this.Controls)
            {
                c.BackColor = Program.BackColor;
            }
            this.passTextBox1.ForeColor = Program.ForeColor;
            this.passTextBox2.ForeColor = Program.ForeColor;
            this.userTextBox.ForeColor = Program.ForeColor;
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
