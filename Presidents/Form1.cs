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
    /// Purpose: Presidents order guessing game and wikipedia browser
    /// </summary>
    public partial class PresidentsForm : Form
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

        public PresidentsForm()
        {
            InitializeComponent();

            // Enable Internet Explorer v12
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident /
                //7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx
                //1.0.0)
Microsoft.Win32.RegistryKey key =
Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
@"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\
FeatureControl\\FEATURE_BROWSER_EMULATION",
true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001,
                Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }

            // Add all of the president radio buttons to presidentButtons
            foreach (Control control in this.Controls)
            {
                try { presidentButtons.Add((RadioButton)control); } catch { }
            }
            // Add all of the president text boxes to presidentNumBoxes
            foreach (Control control in this.Controls)
            {
                try { presidentNumBoxes.Add((TextBox)control); } catch { }
            }

            // Add PresRadioButton__CheckedChanged eventhandler to all President radio buttons
            this.bhRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.fdrRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.wjcRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.jbRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.fpRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.gwbRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.boRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.jfkRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.wmkRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.rrRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.ddeRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.mvbRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.gwRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.jaRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.trRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);
            this.tjRadioButton.CheckedChanged += new EventHandler(PresRadioButton__CheckedChanged);

            // Add PresTextBox__KeyPress keypresseventhandler to all President text boxes
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

            // Add PresTextBox__Validating canceleventhandler to all President text boxes
            this.bhTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.fdrTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.wjcTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.jbTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.fpTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.gwbTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.boTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.jfkTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.wmkTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.rrTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.ddeTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.mvbTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.gwTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.jaTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.trTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);
            this.tjTextBox.Validating += new CancelEventHandler(PresTextBox__Validating);

            // Add FilterRadioButton__CheckChanged to all radio buttons in Filter Group Box
            this.allRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);
            this.dRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);
            this.rRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);
            this.drRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);
            this.fRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckChanged);

            // Add PortraitPictureBox__MouseEnter eventhandler to Portrait Picture Box
            this.portraitPictureBox.MouseEnter += new EventHandler(PortraitPictureBox__MouseEnter);
            // Add PortraitPictureBox__MouseLeave eventhandler to Portrait Picture Box
            this.portraitPictureBox.MouseLeave += new EventHandler(PortraitPictureBox__MouseLeave);

            // Disable Exit Button
            this.exitButton.Enabled = false;
            // Add ExitButton__Click eventhandler to Exit Button
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // Set Tool Strip Progress Bar value to full 
            this.toolStripProgressBar.Value = 240;
            // Add Timer__Tick eventhandler to Timer
            this.timer.Tick += new EventHandler(Timer__Tick);

            // Add WebBrowser__DocumentCompleted to webBrowser
            this.webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser__DocumentCompleted);
        }

        // president radio buttons Check Changed Event
        private void PresRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton presidentButton = (RadioButton)sender;
            // if this is the active president button
            if (presidentButton.Checked)
            {
                // re-format names from radio buttons for browsing
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

                // If Obama -> extension is ".png"
                if (imgName.Equals("BarackObama")) { imgExt = ".png"; }
                // set portrait to new President
                this.portraitPictureBox.ImageLocation = "http://people.rit.edu/dxsigm/" + imgName + imgExt;

                // set web browser to president
                this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/" + wikiName;
                this.webBrowser.Navigate(new Uri("https://en.m.wikipedia.org/wiki/" + wikiName));
            }
        }

        // president text boxes
        private void PresTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            // dont handle non-digit/backspace keypresses
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b') 
            {
                e.Handled = false;

                // start game when first number is inputted
                if (!gamestart)
                {
                    gamestart = true;
                    // Start Timer
                    timer.Start();
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PresTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            string givenAnswer = tb.Text;
            string correctAnswer = correctAnswers[tb.Name];

            // If answer in the given Text Box is not the same as the correct answer
            if (givenAnswer != correctAnswer)
            {
                // Give and error
                this.errorProvider.SetError(tb, "Incorrect #");
                // Cancel the event
                e.Cancel = true;
                // Set given text box’s tag to false (wrong)
                tb.Tag = false;
            }
            // if they are the same
            else
            {
                // Give no error
                this.errorProvider.SetError(tb, null);
                // Dont cancel the event
                e.Cancel = false;
                // Set given text box’s tag to true (correcy)
                tb.Tag = true;
            }

            // Check if all answers are correct
            ValidateAll();
        }

        // filter radio buttons
        private void FilterRadioButton__CheckChanged(object sender, EventArgs e)
        {
            RadioButton filterButton = (RadioButton)sender;

            // if this radio button is selected
            if (filterButton.Checked)
            {
                String party = filterButton.Text;

                // iterate through presidentButtons
                foreach (RadioButton presidentRadioButton in presidentButtons)
                {
                    // compare this button's text to the tag of each president radio button
                    if (presidentRadioButton.Tag.ToString() == party || party == "All")
                    {
                        // show buttons of correct party 
                        presidentRadioButton.Visible = true;
                    }
                    else
                    {
                        // hide buttons of incorrect party
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
            // increase picture box size
            portraitPictureBox.Size = new Size(300, 300);
        }
        private void PortraitPictureBox__MouseLeave(object sender, EventArgs e)
        {
            // return picture box size to normal
            portraitPictureBox.Size = new Size(170, 240);
        }

        // exit button click event
        private void ExitButton__Click(object sender, EventArgs e)
        {
            // close application
            Application.Exit();
        }

        // Timer tick event
        private void Timer__Tick(object sender, EventArgs e)
        {
            // Decrease progress bar by 1
            this.toolStripProgressBar.Value--;

            // If Tool Strip Progress Bar Reaches 0
            if (toolStripProgressBar.Value == 0)
            {
                // Stop Timer
                this.timer.Stop();
                // Reset Progress Bar
                this.toolStripProgressBar.Value = 240;
                // Set gamestart to false
                gamestart = false;
                // Set all President Text Boxes back to 0
                foreach (TextBox numBox in presidentNumBoxes)
                {
                    numBox.Text = "0";
                }
            }
        }

        private void WebBrowser__DocumentCompleted(object sender, EventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;

            HtmlElementCollection htmlElementCollection = wb.Document.GetElementsByTagName("a");

            // Set the title of each element on the web browser Document with tag “a” to: “Prof Schuh for President!”
            foreach (HtmlElement element in htmlElementCollection)
            {
                element.SetAttribute("title", "Prof Schuh for President!");
            }
        }

        // check if game won
        private void ValidateAll()
        {
            // iterate each President Text Box and count correct answers
            int x = 0;
            foreach (TextBox numBox in this.presidentNumBoxes)
            {
                // count correct answers
                if (numBox.Text == this.correctAnswers[numBox.Name])
                {
                    x++;
                }
            }

            // if there are 16 correct answers (all text boxes are correct)
            if (x == 16)
            {
                // stop timer
                this.timer.Stop();

                // Web Browser Box displays link
                this.webGroupBox.Text = "https://www.youtube.com/embed/18212B4yfLg?autoplay=1";
                // Web Browser opens fireworks youtube video
                this.webBrowser.Navigate("https://www.youtube.com/embed/18212B4yfLg?autoplay=1");

                // enable exit button
                this.exitButton.Enabled = true;
            }
        }
    }
}
