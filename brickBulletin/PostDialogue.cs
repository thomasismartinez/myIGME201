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
    public partial class PostDialogue : Form
    {
        public PostDialogue()
        {
            InitializeComponent();
            cancelPostButton.DialogResult = DialogResult.OK;
            goBackButton.DialogResult = DialogResult.Cancel;
        }
    }
}
