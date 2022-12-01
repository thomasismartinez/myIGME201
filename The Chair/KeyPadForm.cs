using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Chair
{
    public partial class KeyPadForm : Form
    {
        Random rand = new Random();
        CubeForm parent;
        List<Button> buttons = new List<Button>();
        public KeyPadForm(CubeForm cube)
        {
            InitializeComponent();

            this.parent = cube;

            // Add all input buttons to buttons list
            foreach (Control c in this.Controls)
            {
                try { buttons.Add((Button)c); } catch { }
            }
            buttons.Remove(this.enterButton);

            // Add 
            this.button0.Click += new EventHandler(Button__Click);
            this.button1.Click += new EventHandler(Button__Click);
            this.button2.Click += new EventHandler(Button__Click);
            this.button3.Click += new EventHandler(Button__Click);
            this.button4.Click += new EventHandler(Button__Click);
            this.button5.Click += new EventHandler(Button__Click);
            this.button6.Click += new EventHandler(Button__Click);
            this.button7.Click += new EventHandler(Button__Click);
            this.button8.Click += new EventHandler(Button__Click);
            this.button9.Click += new EventHandler(Button__Click);
            this.buttonThrembo.Click += new EventHandler(Button__Click);

            this.deleteButton.Click += new EventHandler(DeleteButton__Click);
            this.enterButton.Click += new EventHandler(EnterButton__Click);

            if (cube.thremboMode)
            {
                this.buttonThrembo.Visible = true;
            }
        }

        private void Button__Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.inputLabel.Text = this.inputLabel.Text += button.Text;
        }
        private void DeleteButton__Click(object sender, EventArgs e)
        {
            if (this.inputLabel.Text.Length > 0)
            {
                this.inputLabel.Text = this.inputLabel.Text.Substring(0, this.inputLabel.Text.Length - 1);
            }
        }
        private void EnterButton__Click(object sender, EventArgs e)
        {
            parent.InputAnswer(inputLabel.Text);
            this.Close();
        }

        public void SwapButtons(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Button b1 = buttons[rand.Next(0, 12)];
                Button b2 = buttons[rand.Next(0, 12)];

                Point posOne = new Point(b1.Location.X, b1.Location.Y);
                b1.Location = new Point(b2.Location.X, b2.Location.Y);
                b2.Location = posOne;
            }
        }
    }
}
