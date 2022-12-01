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
        private CubeForm cubeForm;
        private SmashForm smashForm;
        private int[] foodAmounts = new int[] { 0,1,1,1,1,1,1,1,1,1,0,0,1 };
        private List<Label> radioButtonCounters = new List<Label>();
        private List<RadioButton> radioButtons = new List<RadioButton>();
        private List<Button> buttons = new List<Button>();
        private bool unhappy = false;
        private bool feedable = false;
        public bool cubeRiddlesComplete = false;
        private int hungerTime = 50;
        private bool strikable = true;
        private bool strokable = true;
        private int sitTime = 100;
        private int shopTime = 0;
        private int angryTime = 0;
        public int cubeTime = 20;
        private bool cubeAppeared = false;
        private int feedCriteria;
        private int gluppMultiplier = 1;
        public ChairForm()
        {
            InitializeComponent();

            // WIN BUTTON
            this.winButton.Click += new EventHandler(WinButton__Click);
            // WIN BUTTON

            // create and show smash chair form
            smashForm = new SmashForm();
            smashForm.Show();
            
            this.Text = Program.randCap(this.Text);

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
            // WIN BUTTON
            buttons.Remove(winButton);
            // WIN BUTTON

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
            // Add GluppCheckBox__Click ceventhandler to gluppCheckBox
            this.gluppCheckBox.Click += new EventHandler(GluppCheckBox__Click);

            // Set happinessProgressBar's value to half
            this.happinessToolStripProgressBar.Value = 5000;

            // Add Timer__Tick eventhandler to timer
            this.timer.Tick += new EventHandler(Timer__Tick);
            // Start timer
            this.timer.Start();
        }
        // WIN BUTTON
        private void WinButton__Click(object sender, EventArgs e)
        {
            IncreaseHappiness(99999999);
        }
        // WIN BUTTON

        private void FeedChairButton__Click(object sender, EventArgs e)
        {
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
            // Create and open new shopping form
            ShoppingForm shoppingForm = new ShoppingForm(this, ref this.foodAmounts);
            shoppingForm.Show();
        }
        private void StrikeChairButton__Click(object sender, EventArgs e)
        {
            if (hungerTime > 30 && strikable)
            {
                IncreaseHappiness(500);
                strikable = false;
            }
            else
            {
                DecreaseHappiness(500);
            }
        }
        private void StrokeChairButton__Click(object sender, EventArgs e)
        {
            if (hungerTime == 0 && strokable)
            {
                IncreaseHappiness(500);
                strokable = false;
            }
            else
            {
                DecreaseHappiness(500);
            }
        }
        private void SitChairButton__Click(object sender, EventArgs e)
        {
            this.sitChairButton.Enabled = false;
            sitTime = 100;
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

                // Randomely capitalize a random radio button
                int randRad = random.Next(0, radioButtons.Count);
                radioButtons[randRad].Text = Program.randCap(radioButtons[randRad].Text);
            }
        }

        private void GluppCheckBox__Click(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                if (cubeRiddlesComplete)
                {
                    gluppMultiplier = 3;
                }
                else
                {
                    this.outputLabel.Text = Program.randCap("not until you solve all of the cube's riddles!!");
                    gluppCheckBox.Checked = false;
                }
            }
            else
            {
                gluppMultiplier = 1;
            }

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            if (hungerTime > 1)
            {
                hungerTime--;
                strikable = true;
            }
            else if (hungerTime == 1) 
            {
                hungerTime--;
                outputLabel.Text = "The chair is hungry now...";
            }
            else 
            {
                feedable = true;
                DecreaseHappiness(5);
            }

            if (angryTime > 1)
            {
                angryTime--;
            }
            else if (angryTime == 1)
            {
                angryTime--;
                this.angryPictureBox.Visible = false;
            }

            if (sitTime > 1)
            {
                sitTime--;
            }
            else if (sitTime == 1)
            {
                sitTime--;
                this.sitChairButton.Enabled = true;
            }

            if (shopTime > 1)
            {
                shopTime--;
            }
            else if (shopTime == 1)
            {
                shopTime--;
                this.shopButton.Enabled = true;
            }

            if (cubeTime > 1)
            {
                cubeTime--;
            }
            else if ( cubeTime == 1)
            {
                cubeTime--;
                if (!cubeAppeared)
                {
                    this.cubeAppeared = true;
                    this.outputLabel.Text = Program.randCap("The Cube is here. Answer it's riddles!");
                    cubeForm = new CubeForm(this);
                    cubeForm.Show();
                }
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
                    this.outputLabel.Text = Program.randCap("You're all out of radioButton" + buttonNum + "s!");
                }
            }
            else
            {
                this.outputLabel.Text = Program.randCap("The chair is not hungry");
            }
        }

        private void Feed(int buttonNum)
        {
            hungerTime = 50;
            foodAmounts[buttonNum]--;
            UpdateRadioButtonCount();
            this.outputLabel.Text = Program.randCap("The chair is full now");
            strokable = true;
            feedable = false;
        }

        private void FailFeed(string criteria)
        {
            this.outputLabel.Text = Program.randCap("The Chair only likes Radio Buttons with " + criteria + ".");
            angryTime = 10;
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
            for (int i = 0; i < 10; i++)
            {
                int buttonNum = Int32.Parse(radioButtonCounters[i].Name.Substring(16));
                radioButtonCounters[i].Text = foodAmounts[buttonNum].ToString();
            }

            if (this.shopButton.Enabled)
            {
                this.shopButton.Enabled = false;
                this.shopTime = 100;
            }
        }

        public void DecreaseHappiness(int happyPoints)
        {
            try { happinessToolStripProgressBar.Value -= happyPoints; }
            catch {
                happinessToolStripProgressBar.Value -= happinessToolStripProgressBar.Value;
                if (!unhappy)
                {
                    this.unhappy = true;
                    this.outputLabel.Text = "the chair is very unhappy";
                    this.unhappyPictureBox.Visible = true;
                }
            }
        }

        public void IncreaseHappiness(int happyPoints)
        {
            int increase = happyPoints * gluppMultiplier;
            try 
            {
                happinessToolStripProgressBar.Value += increase;
                if (unhappy)
                {
                    this.unhappyPictureBox.Visible = false;
                }
            }
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
