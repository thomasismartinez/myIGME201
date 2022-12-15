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

        public SearchForm()
        {
            InitializeComponent();

            this.searchButton.Click += new EventHandler(searchButton__Click);
            string searchKey = this.searchKeyText.Text;
        }

        private void searchButton__Click(object sender, EventArgs e)
        {
            searchResults.Text = "Search Results: ";

            // search user list for keyword
            foreach (KeyValuePair<string, User> user in Program.groups)
            {
                if(user.Value.name.ToLower().Contains((searchKeyText.Text.ToLower()))) // if keyword is valid
                {
                    searchResults.Text += user.Value.name; // display username in search results
                }
            }
        }

    }
}
