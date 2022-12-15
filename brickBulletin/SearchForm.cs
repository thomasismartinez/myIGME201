// Rose Silletto
// IGME 201 Group Project
// Brick Bulletin

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brickBulletin
{
    public partial class SearchForm : Form
    {
        HomeForm homeForm;
        public SearchForm(HomeForm homeForm)
        {
            InitializeComponent();

            this.homeForm = homeForm;

            this.searchButton.Click += new EventHandler(searchButton__Click);
            string searchKey = this.searchKeyText.Text;
            this.homeForm = homeForm;
        }

        private void searchButton__Click(object sender, EventArgs e)
        {
            this.searchResultsFlowLayoutPanel.Controls.Clear();

            // search user list for keyword
            foreach (KeyValuePair<string, User> user in Program.groups)
            {
                if(user.Value.name.ToLower().Contains((searchKeyText.Text.ToLower()))) // if keyword is valid
                {
                    Button button = new Button();
                    button.Click += new EventHandler(Button__Click);
                    button.Text = user.Value.name;
                    button.Width = 250;
                    this.searchResultsFlowLayoutPanel.Controls.Add(button);
                }
            }
        }

        private void Button__Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            homeForm.currentPage = b.Text;
            this.Hide();
        }
    }
}
