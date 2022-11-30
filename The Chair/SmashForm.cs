using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Chair
{
    public partial class SmashForm : Form
    {
        public SmashForm()
        {
            InitializeComponent();

            // Add SmashButton__Click eventhandler to Smash Button
            this.smashButton.Click += new EventHandler(SmashButton__Click);
        }

        private void SmashButton__Click(object sender, EventArgs e)
        {
            // Display quitting messege
            MessageBox.Show("You will forever be disatisfied with your inability to please the chair",
                "You are free", MessageBoxButtons.OK);
            // Exit Application
            Application.Exit();
        }
    }
}
