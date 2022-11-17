using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17MultipleForms
{
    public partial class ParametersForm : Form
    {
        public ParametersForm()
        {
            InitializeComponent();

            // Event handlers
            this.startButton.Click += new EventHandler(StartButton__Click);

            this.lowEndTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.highEndTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse
            lowNumber = Int32.Parse(this.lowEndTextBox.Text);
            highNumber = Int32.Parse(this.highEndTextBox.Text);

            // if not a valid range
            if ( ( lowNumber < 1 || lowNumber > 100) || ( highNumber > 100 || highNumber < 1) )
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.\nRange must be within 1 and 100.");
            }
            else if ( lowNumber > highNumber )
            {
                MessageBox.Show("The numbers are invalid.\nHigh End must be greater than Low End.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
