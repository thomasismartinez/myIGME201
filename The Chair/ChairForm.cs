using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Button = System.Windows.Forms.Button;

namespace The_Chair
{
    public partial class ChairForm : Form
    {
        Random random = new Random();
        private CubeForm cubeForm; // cube form that asks questions for this form
        private SmashForm smashForm; // smash form that allows program to be closed at any time
        private int[] foodAmounts = new int[] { 0,1,1,1,1,1,1,1,1,1,0,0,1 }; // count of amount of each radio button user has sorted by index number
        private List<Label> radioButtonCounters = new List<Label>(); // List of radio button labels for iteration
        private List<RadioButton> radioButtons = new List<RadioButton>(); // List radio buttons for iteration
        private List<Button> buttons = new List<Button>(); // List of buttons for iteration
        private bool unhappy = false; // weather or not happiness is 0
        private bool feedable = false; // is the chair can be fed
        public bool cubeRiddlesComplete = false; // if the cube's riddles have been completed
        private int hungerTime = 50; // milliseconds until chair gets hungry
        private bool strikable = true; // weather or not the chair can be struck
        private bool strokable = true; // weather or not the chair can be strocked
        private int sitTime = 100; // milliseconds until the chair can be sat in
        private int shopTime = 0; // milliseconds until the grocery store can be opened
        private int angryTime = 0; // milliseconds until chair stops being angry
        public int cubeTime = 300; // milliseconds until cube asks a question
        private bool cubeAppeared = false; // weather or not the cube has appeared yet
        private int feedCriteria; // selector of criteria for what radio buttons the chair likes
        private int gluppMultiplier = 1; // happiness multiplier
        public ChairForm()
        {
            InitializeComponent();

            // create and show smash chair form
            smashForm = new SmashForm();
            smashForm.Show();

            // Add all radio button counters to radioButtonCounts
            foreach (Control control in this.feedGroupBox.Controls)
            {
                try { radioButtonCounters.Add((Label)control); } catch { }
            }
            // Add all radio buttons to radioButtons
            foreach (Control control in this.feedGroupBox.Controls)
            {
                try { radioButtons.Add((RadioButton)control); } catch { }
            }
            // Add all buttons to buttons
            foreach (Control control in this.Controls)
            {
                try { buttons.Add((Button)control); } catch { }
            }

            // select first random feeding criteria
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
            // Add GluppCheckBox__Click ceventhandler to gluppCheckBox
            this.gluppCheckBox.Click += new EventHandler(GluppCheckBox__Click);

            // Set happinessProgressBar's value to half
            this.happinessToolStripProgressBar.Value = 5000;

            // Add Timer__Tick eventhandler to timer
            this.timer.Tick += new EventHandler(Timer__Tick);
            // Start timer
            this.timer.Start();
        }

        private void FeedChairButton__Click(object sender, EventArgs e)
        {
            // Attempt to feed checked radio button to the chair
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Checked)
                {
                    AttemptFeed(Int32.Parse(rb.Text.Substring(11)));
                }
            }
        }
        private void ShopButton__Click(object sender, EventArgs e)
        {
            // Create and show new shopping form
            ShoppingForm shoppingForm = new ShoppingForm(this, ref this.foodAmounts);
            shoppingForm.Show();
        }
        private void StrikeChairButton__Click(object sender, EventArgs e)
        {
            // if chair just at and the user hasn't struck the chair since it last ate
            if (hungerTime > 30 && strikable)
            {
                IncreaseHappiness(500);
                strikable = false;
            }
            else
            {
                this.outputLabel.Text = "That only works if the chair just ate";
                DecreaseHappiness(500);
            }
        }
        private void StrokeChairButton__Click(object sender, EventArgs e)
        {
            // if chair is hungry and hasn't been stroked since it became so
            if (hungerTime == 0 && strokable)
            {
                IncreaseHappiness(500);
                strokable = false;
            }
            else
            {
                this.outputLabel.Text = "That only works once while the chair is hungry";
                DecreaseHappiness(500);
            }
        }
        private void SitChairButton__Click(object sender, EventArgs e)
        {
            // disable sit button andreset sit timer
            this.sitChairButton.Enabled = false;
            sitTime = 100;

            // randomly select weather or not to make chair happier
            int chance = random.Next(0, 100);
            if (happinessToolStripProgressBar.Value < 10000 && chance > 95)
            {
                IncreaseHappiness(3000);
            }
            else if (happinessToolStripProgressBar.Value < 6666 && chance > 75)
            {
                IncreaseHappiness(3000);
            }
            else if (happinessToolStripProgressBar.Value < 3333 && chance > 50)
            {
                IncreaseHappiness(3000);
            }
            else
            {
                // select two random buttons
                int b1Index = random.Next(0,buttons.Count);
                int b2Index;
                while (true)
                {
                    b2Index = random.Next(0,buttons.Count);
                    if (b1Index != b2Index) { break; }
                }

                Button b1 = buttons[b1Index];
                Button b2 = buttons[b2Index];

                // swap the position of those buttons
                Point posOne = new Point(b1.Location.X, b1.Location.Y);
                b1.Location = new Point(b2.Location.X, b2.Location.Y);
                b2.Location = posOne;

                // Randomly capitalize a random radio button
                int randRad = random.Next(0, radioButtons.Count);
                radioButtons[randRad].Text = Program.randCap(radioButtons[randRad].Text);
            }
        }

        private void GluppCheckBox__Click(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            // If box is checked and the cube's riddles are complete
            if (cb.Checked && cubeRiddlesComplete)
            {
                gluppMultiplier = 3;
            }
            // else undo check and tell user why
            else
            {
                this.outputLabel.Text = Program.randCap("not until you solve all of the cube's riddles!!");
                gluppCheckBox.Checked = false;
            }

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            // Decrement all timers above 0

            if (hungerTime > 1)
            {
                hungerTime--;
                strikable = true;
            }
            // when hungerTime runs out
            else if (hungerTime == 1) 
            {
                hungerTime--;
                // set feedable to true
                feedable = true;
                // output that chair is hungry
                outputLabel.Text = "The chair is hungry now...";
            }
            // Decrease Happiness by 5 every time cubeTime is at 0
            else
            {
                DecreaseHappiness(5);
            }

            if (angryTime > 1)
            {
                angryTime--;
            }
            // when anmgryTime runs out hide angryPictureBox
            else if (angryTime == 1)
            {
                angryTime--;
                this.angryPictureBox.Visible = false;
            }

            if (sitTime > 1)
            {
                sitTime--;
            }
            // when sitTime runs out enable Sit Button
            else if (sitTime == 1)
            {
                sitTime--;
                this.sitChairButton.Enabled = true;
            }

            if (shopTime > 1)
            {
                shopTime--;
            }
            // when shopTime runs out enable Shop Button
            else if (shopTime == 1)
            {
                shopTime--;
                this.shopButton.Enabled = true;
            }

            if (cubeTime > 1)
            {
                cubeTime--;
            }

            // when cubeTime runs out
            else if ( cubeTime == 1)
            {
                cubeTime--;
                // create cube if it hasn't appeared yet
                if (!cubeAppeared)
                {
                    this.cubeAppeared = true;
                    this.outputLabel.Text = Program.randCap("The Cube is here. Answer it's riddles!");
                    cubeForm = new CubeForm(this);
                    cubeForm.Show();
                }
                // have cube ask question
                cubeForm.NewQuestion();
            }
        }

        private void AttemptFeed(int buttonNum)
        {
            if (feedable)
            {
                int x = foodAmounts[buttonNum];
                if (foodAmounts[buttonNum] != 0)
                {
                    // Check if button the user is trying to feed fits the chair’s criteria
                    switch (feedCriteria)
                    {
                        case 1: // Prime
                            if (IsPrime(buttonNum))
                            { Feed(buttonNum); }
                            else
                            {
                                FailFeed("prime numbers");
                            }
                            break;
                        case 2: // Even
                            if (buttonNum % 2 == 0)
                            { Feed(buttonNum); }
                            else
                            {
                                FailFeed("even numbers");
                            }
                            break;
                        case 3: // Odd
                            if (buttonNum % 2 == 1)
                            { Feed(buttonNum); }
                            else
                            {
                                FailFeed("Odd numbers");
                            }
                            break;
                        case 4: // Divisible by 3
                            if (buttonNum % 3 == 0)
                            { Feed(buttonNum); }
                            else
                            {
                                FailFeed("numbers divisible by 3");
                            }
                            break;
                    }
                }
                else
                {
                    // If the user is out of that radio button don’t go any further and tell the user
                    this.outputLabel.Text = Program.randCap("You're all out of radioButton" + buttonNum + "s!");
                }
            }
            else
            {
                // dont feed and tell user if chair cannot be fed
                this.outputLabel.Text = Program.randCap("The chair is not hungry");
            }
        }

        private void Feed(int buttonNum)
        {
            // reset hunger time
            hungerTime = 50;
            // decrease count for fed radio button by one
            foodAmounts[buttonNum]--;
            // Update radio button count
            UpdateRadioButtonCount();
            // tell user the chair is full
            this.outputLabel.Text = Program.randCap("The chair is full now");
            // make chair strokable and not feedable
            strokable = true;
            feedable = false;
        }

        private void FailFeed(string criteria)
        {
            // Tell user the correct feeding criteria
            this.outputLabel.Text = Program.randCap("The Chair only likes Radio Buttons with " + criteria + ".");
            // reset angry time 
            angryTime = 10;
            // display angry chair picture box
            this.angryPictureBox.Visible = true;
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

        // Update radio button counters
        public void UpdateRadioButtonCount()
        {
            // iterate through radio button labels
            for (int i = 0; i < 10; i++)
            {
                int buttonNum = Int32.Parse(radioButtonCounters[i].Name.Substring(16));
                // update count based on foodAmounts
                radioButtonCounters[i].Text = foodAmounts[buttonNum].ToString();
            }

            // if shop button is enabled
            if (this.shopButton.Enabled)
            {
                // disable shop button
                this.shopButton.Enabled = false;
                // reset shopTime
                this.shopTime = 100;
            }
        }

        public void DecreaseHappiness(int happyPoints)
        {
            try { happinessToolStripProgressBar.Value -= happyPoints; }
            // if happiness decrease exceeds remaining happiness level
            catch {
                // set chair happiness to 0
                happinessToolStripProgressBar.Value -= happinessToolStripProgressBar.Value;
                if (!unhappy)
                {
                    // make chair unhappy
                    this.unhappy = true;
                    // tell user the chair is very unhappy
                    this.outputLabel.Text = "the chair is very unhappy";
                    // show unhappy chair picture box
                    this.unhappyPictureBox.Visible = true;
                }
            }
        }

        public void IncreaseHappiness(int happyPoints)
        {
            // increase happiness by given amount multiplied by glupp multiplier
            int increase = happyPoints * gluppMultiplier;
            try 
            {
                happinessToolStripProgressBar.Value += increase;
                if (unhappy)
                {
                    // hide unhappy picture box
                    this.unhappyPictureBox.Visible = false;
                }
            }
            // when increase exceeds remaining progress bar space you win
            catch 
            {
                // set chair happiness to empty
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
