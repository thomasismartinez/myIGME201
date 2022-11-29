using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Presidents
{
    /// <summary>
    /// Program: President.cs
    /// Author: Thomas Martinez
    /// Purpose: President order guessing game and wikipedia browser
    /// </summary>
    public partial class Form1 : Form
    {
        private List<RadioButton> presidentButtons = new List<RadioButton>();
        private List<TextBox> presidentNumBoxes = new List<TextBox>();
        private SortedList<string, string> correctAnswers = new SortedList<string, string>()
        {
            { "bhTextBox", "23" },
            { "fdrTextBox", "32" },
            { "wjcTextBox", "42" },
            { "jbTextBox", "15" },
            { "fpTextBox", "14" },
            { "gwbTextBox", "43" },
            { "boTextBox", "44" },
            { "jfkTextBox", "35" },
            { "wmkTextBox", "25" },
            { "rrTextBox", "40" },
            { "ddeTextBox", "34" },
            { "mvbTextBox", "8" },
            { "gwTextBox", "1" },
            { "jaTextBox", "2" },
            { "trTextBox", "26" },
            { "tjTextBox", "3" }
        };
        bool gamestart = false;

        public Form1()
        {
            InitializeComponent();

            // list of president radio buttons
            foreach (Control control in this.Controls)
            {
                try { presidentButtons.Add((RadioButton)control); } catch { }
            }
            // list of president text boxes
            foreach (Control control in this.Controls)
            {
                try { presidentNumBoxes.Add((TextBox)control); } catch { }
            }

            // president radio buttons
            this.bhRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.fdrRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.wjcRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.jbRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.fpRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.gwbRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.boRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.jfkRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.wmkRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.rrRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.ddeRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.mvbRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.gwRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.jaRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.trRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);
            this.tjRadioButton.CheckedChanged += new EventHandler(PresRadioButton__Check);

            // president text box key presses
            this.bhTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.fdrTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.wjcTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.jbTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.fpTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.gwbTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.boTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.jfkTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.wmkTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.rrTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.ddeTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.mvbTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.gwTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.jaTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.trTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);
            this.tjTextBox.KeyPress += new KeyPressEventHandler(PresTextBox__KeyPress);

            // president text box leave
            this.bhTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.fdrTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.wjcTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.jbTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.fpTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.gwbTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.boTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.jfkTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.wmkTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.rrTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.ddeTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.mvbTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.gwTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.jaTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.trTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);
            this.tjTextBox.Validating += new CancelEventHandler(PreTextBox__Validating);

            //filter buttons
            this.allRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);
            this.dRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);
            this.rRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);
            this.drRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);
            this.fRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);

            // picture box
            this.portraitPictureBox.MouseEnter += new EventHandler(PortraitPictureBox__MouseEnter);
            this.portraitPictureBox.MouseLeave += new EventHandler(PortraitPictureBox__MouseLeave);

            // exit button
            this.exitButton.Enabled = false;
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // timer 
            this.toolStripProgressBar.Value = 240;
            this.timer.Tick += new EventHandler(Timer__Tick);
        }

        // president radio buttons
        private void PresRadioButton__Check(object sender, EventArgs e)
        {
            RadioButton presidentButton = (RadioButton)sender;
            // check if this is the active president button
            if (presidentButton.Checked)
            {
                // re-format names for browsing
                StringBuilder wikiNameBuilder = new StringBuilder();
                StringBuilder imgNameBuilder = new StringBuilder();
                foreach (Char c in presidentButton.Text)
                {
                    if (!c.Equals(' '))
                    {
                        wikiNameBuilder.Append(c.ToString());
                        imgNameBuilder.Append(c.ToString());
                    }
                    else
                    {
                        wikiNameBuilder.Append("_");
                    }
                }
                String wikiName = wikiNameBuilder.ToString();
                String imgName = imgNameBuilder.ToString();
                String imgExt = ".jpeg";

                // set portrait to new President
                if (imgName.Equals("BarackObama")) { imgExt = ".png"; }
                this.portraitPictureBox.ImageLocation = "http://people.rit.edu/dxsigm/" + imgName + imgExt;

                // set web browser to president
                this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/" + wikiName;
                this.webBrowser.Navigate(new Uri("https://en.m.wikipedia.org/wiki/" + wikiName));
            }
        }

        // president text boxes
        private void PresTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            // handle none digit/backspace keypresses
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b') 
            {
                e.Handled = false;

                // start game when first number is inputted
                if (!gamestart)
                {
                    gamestart = true;
                    timer.Start();
                }
            }
            // else dont input character
            else
            {
                e.Handled = true;
            }
        }

        private void PreTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            string givenAnswer = tb.Text;
            string correctAnswer = correctAnswers[tb.Name];

            if (givenAnswer != correctAnswer)
            {
                this.errorProvider.SetError(tb, "Incorrect #");
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        // filter radio buttons
        private void FilterRadioButton__CheckChanged(object sender, EventArgs e)
        {
            RadioButton filterButton = (RadioButton)sender;

            // check if this radio button is selected
            if (filterButton.Checked)
            {
                // compare this button's text to the tag of each president radio button
                String party = filterButton.Text;

                foreach (RadioButton presidentRadioButton in presidentButtons)
                {
                    if (presidentRadioButton.Tag.ToString() == party || party == "All")
                    {
                        // show correct party 
                        presidentRadioButton.Visible = true;
                    }
                    else
                    {
                        // hide incorrect party
                        presidentRadioButton.Visible = false;
                    }
                }
            }
        }

        // picture box

        // when portraitPictureBox is hovered over with the mouse:
        //     increase its size until it is no longer being hovered over
        private void PortraitPictureBox__MouseEnter(object sender, EventArgs e)
        {
            portraitPictureBox.Size = new Size(300, 300);
        }
        private void PortraitPictureBox__MouseLeave(object sender, EventArgs e)
        {
            portraitPictureBox.Size = new Size(170, 240);
        }

        // exit button
        private void ExitButton__Click(object sender, EventArgs e)
        {
            // close application
            Application.Exit();
        }

        // timer every tick
        private void Timer__Tick(object sender, EventArgs e)
        {
            // decrease progress bar
            this.toolStripProgressBar.Value--;

            if (toolStripProgressBar.Value == 0)
            {
                // reset game
                this.timer.Stop();
                this.toolStripProgressBar.Value = 240;
                gamestart = false;

                foreach (TextBox numBox in presidentNumBoxes)
                {
                    numBox.Text = "0";
                }
            }
        }

        // check if game won
        private void ValidateAll()
        {
            int x = 0;
            foreach (TextBox numBox in presidentNumBoxes)
            {
                if (numBox.Text == correctAnswers[numBox.Name])
                {
                    x++;
                }
            }

            if (x == 16)
            {
                // stop game
                this.timer.Stop();

                // navigate to victory video
                this.webGroupBox.Text = "https://www.youtube.com/watch?v=cWqNcXyH-s0";
                this.webBrowser.Navigate("https://www.youtube.com/watch?v=cWqNcXyH-s0");

                // enable exit button
                this.exitButton.Enabled = true;
            }
        }
    }
}
