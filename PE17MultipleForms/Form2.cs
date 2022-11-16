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
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {

        }

        private void Timer__Tick(object sender, EventArgs e)
        {

        }
    }
}
