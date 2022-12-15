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
            
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
