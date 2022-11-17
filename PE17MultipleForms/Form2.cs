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
    public partial class GameForm : Form
    {
        private int lowEnd;
        private int highEnd;
        private int secretNumber;
        private int nGuesses = 0;

        public GameForm(int low, int high)
        {
            InitializeComponent();

            // store game parameters
            lowEnd = low;
            highEnd = high;

            // choose random answer
            Random rand = new Random();
            secretNumber = rand.Next(lowEnd, highEnd+1);

            // event handlers
            this.guessButton.Click += new EventHandler(GuessButton__Click);

            this.timer.Tick += new EventHandler(Timer__Tick);

            this.currentGuessTextBox.KeyPress += new KeyPressEventHandler(CurrentGuessTextBox__KeyPress);

            // begin timing
            this.timer.Interval = 1000;
            this.timer.Start();
            this.toolStripProgressBar.Value = 45;
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            // increment Guess count
            nGuesses++;

            // check inputted value
            if (Int32.Parse(this.currentGuessTextBox.Text) == secretNumber)
            {
                // stop timer;
                this.timer.Stop();
                // display win messege
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                // close form
                this.Close();
            }
            else if (Int32.Parse(this.currentGuessTextBox.Text) > secretNumber)
            {
                // correct user with output label
                this.outputLabel.Text = this.currentGuessTextBox.Text + " is too HIGH";
            }
            else
            {
                // correct user with output label
                this.outputLabel.Text = this.currentGuessTextBox.Text + " is too LOW";
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            // decrement progress bar
            --this.toolStripProgressBar.Value;

            // check if times run out
            if(this.toolStripProgressBar.Value == 0)
            {
                // stop timer
                this.timer.Stop();
                // tell user they lost
                MessageBox.Show("You ran out of time! The secret number was " + secretNumber);
                // close form
                this.Close();
            }
        }

        // only allow digit input
        private void CurrentGuessTextBox__KeyPress(object sender, KeyPressEventArgs e)
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
