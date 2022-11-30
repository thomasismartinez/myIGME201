using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace The_Chair
{
    public partial class ChairForm : Form
    {
        Random random = new Random();
        private SmashForm smashForm;
        private int[] foodAmounts = new int[] { 0,1,2,3,4,5,6,7,8,9,0,0,12 };
        private List<Label> radioButtonCounters = new List<Label>();
        private List<RadioButton> radioButtons = new List<RadioButton>();
        int hungerTime = 50;
        int feedCriteria;
        public ChairForm()
        {
            InitializeComponent();

            // create and show smash chair form
            smashForm = new SmashForm();
            smashForm.Show();
            
            this.Text = Program.randCap(this.Text);

            // Add all radio button labels to radioButtonCounts
            foreach (Control control in this.Controls)
            {
                try { radioButtonCounters.Add((Label)control); } catch { } 
            }
            // Add all radio buttons to radioButtons
            foreach (Control control in this.feedingGroupBox.Controls)
            {
                try { radioButtons.Add((RadioButton)control); } catch { }
            }

            // select first criteria
            this.feedCriteria = random.Next(1,5);

            // Add FeedChairButton__Click eventhandler to feedChairButton
            this.feedChairButton.Click += new EventHandler(FeedChairButton__Click);
            // Add ShopButton__Click eventhandler to shopButton
            this.shopButton.Click += new EventHandler(ShopButton__Click);
            // Add StrikeChairButton__Click eventhandler to strikeChairButton
            this.strikeChairButton.Click += new EventHandler(StrikeChairButton__Click);
            // Add StrokeChairButton__Click eventhandler to strokeChairButton
            this.strokeChairButton.Click += new EventHandler(StrokeChairButton__Click);
            // Add SitChairButton__Click eventhandler to sitChairButton
            this.sitChairButton.Click += new EventHandler(SitChairButton__Click);

            // Set happinessProgressBar's value to half
            this.happinessToolStripProgressBar.Value = 5000;

            // Add Timer__Tick eventhandler to timer
            this.timer.Tick += new EventHandler(Timer__Tick);
            // Start timer
            this.timer.Start();
        }

        private void FeedChairButton__Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Checked)
                {
                    AttamptFeed(Int32.Parse(rb.Text.Substring(11)));
                }
            }
        }
        private void ShopButton__Click(object sender, EventArgs e)
        {
            // Create and open new shopping form
            ShoppingForm shoppingForm = new ShoppingForm();
            shoppingForm.Show();

            // Update Radio Button counts
            
        }
        private void StrikeChairButton__Click(object sender, EventArgs e)
        {
            IncreaseHappiness(120);
        }
        private void StrokeChairButton__Click(object sender, EventArgs e)
        {

        }
        private void SitChairButton__Click(object sender, EventArgs e)
        {

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            if (hungerTime > 0)
            {
                hungerTime--;
            }
            else 
            {
                DecreaseHappiness(10);
            }
        }

        private void AttamptFeed(int buttonNum)
        {
            if (foodAmounts[buttonNum] == 0)
            {
                switch (feedCriteria)
                {
                    case 1: // Prime
                        if (IsPrime(buttonNum))
                        {
                            hungerTime = 50;
                            foodAmounts[buttonNum]--;
                            this.outputLabel.Text = Program.randCap("The shair is full now");
                        }
                        else
                        {
                            this.outputLabel.Text = Program.randCap("The Chair only likes Radio Buttons with prime numbers");
                        }
                        break;
                    case 2: // Even
                        if (buttonNum % 2 == 1)
                        {
                            hungerTime = 50;
                            foodAmounts[buttonNum]--;
                            this.outputLabel.Text = Program.randCap("The shair is full now");
                        }
                        else
                        {
                            this.outputLabel.Text = Program.randCap("The Chair only likes Radio Buttons with even numbers");
                        }
                        break;
                    case 3: // Odd
                        if (buttonNum % 2 == 1)
                        {
                            hungerTime = 50;
                            foodAmounts[buttonNum]--;
                            this.outputLabel.Text = Program.randCap("The shair is full now");
                        }
                        else
                        {
                            this.outputLabel.Text = Program.randCap("The Chair only likes Radio Buttons with Odd numbers");
                        }
                        break;
                    case 4: // Divisible by 3
                        if (buttonNum % 3 == 0)
                        {
                            hungerTime = 50;
                            foodAmounts[buttonNum]--;
                            this.outputLabel.Text = Program.randCap("The shair is full now");
                        }
                        else
                        {
                            this.outputLabel.Text = Program.randCap("The Chair only likes Radio Buttons with a number divisible by 3.");
                        }
                        break;
                }
            }
            else
            {
                this.outputLabel.Text = Program.randCap("You're all out of radioButton" + buttonNum + "s!");
            }
        }

        // Check if int is prime
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public void DecreaseHappiness(int happyPoints)
        {
            try { happinessToolStripProgressBar.Value -= happyPoints; }
            catch { happinessToolStripProgressBar.Value -= happinessToolStripProgressBar.Value; }
        }

        public void IncreaseHappiness(int happyPoints)
        {
            try { happinessToolStripProgressBar.Value += happyPoints; }
            catch 
            {
                /* YOU WIN THE GAME IF THIS HAPPENS*/
                happinessToolStripProgressBar.Value = happinessToolStripProgressBar.Maximum;
                // stop timer
                timer.Stop();
                // display vitory messege box
                MessageBox.Show(Program.randCap("The chair is happy now, but a piece of you will forever remain with the chair..."),
                    Program.randCap("YOU WON"), MessageBoxButtons.OK);
                // exit application
                Application.Exit();
            }
        }
    }
}
