using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_Chair
{
    public partial class CubeForm : Form
    {
        private Random random = new Random();
        private ChairForm parent;
        private KeyPadForm keyPad;
        private List<string[]> numProblems = new List<string[]>();
        private List<string[]> wordProblems = new List<string[]>();
        private int numOfRiddles = 14;
        private int numProblemsCompleted = 0;
        private int wordProblemsCompleted = 0;
        private string[] currentProblem;
        private bool num; // true = num, false = word
        public bool thremboMode;
        public CubeForm(ChairForm chairForm)
        {
            InitializeComponent();
            
            parent = chairForm;

            // create number problems
            numProblems.Add( new string[] { "1 + 2", "3"});
            numProblems.Add( new string[] { "2 + 2", "4" });
            numProblems.Add( new string[] { "5 * 3", "15" });
            numProblems.Add( new string[] { "6 / 2", "3" });
            numProblems.Add( new string[] { "3 + 4 (assume a digit '%' between 6 and 7)", "%" });
            numProblems.Add( new string[] { "9 + 9 (assume a digit '%' between 6 and 7)", "1%" });
            numProblems.Add( new string[] { "6 * 4 (assume a digit '%' between 6 and 7)", "22" });
            numProblems.Add( new string[] { "13 / %", "2" });
            numProblems.Add( new string[] { "% * %", "45" });

            // create word problems
            wordProblems.Add(new string[] { "first letter in the word 'old'", "o" });
            wordProblems.Add(new string[] { "25th US bresident", "william mckinley" });
            wordProblems.Add(new string[] { "fruit that starts with the letter 'A'", "abble" });
            wordProblems.Add(new string[] { "writing utensil that uses ink", "ben" });
            wordProblems.Add(new string[] { "every letter on the keyboard in qwerty order", "qwertyuiobasdfghjklzxcvbnm" });
            wordProblems.Add(new string[] { "ok fine you can type it once...", "p" });
            wordProblems.Add(new string[] { "ok maybe one more time", "p" });
            wordProblems.Add(new string[] { "what comes between 6 and 7?", "%" });

            // Add SubmitWordButton__Click eventhandler to submitWordButton
            this.submitWordButton.Click += new EventHandler(SubmitWordButton__Click);

            // Add keypresseventhandler towordResponseTextBox
            this.wordResponseTextBox.KeyPress += new KeyPressEventHandler(WordResponseTextBox__KeyPress);

            // Add QTimer__Tick eventhandler to qTimer
            this.qTimer.Tick += new EventHandler(QTimer__Tick);
        }

        private void SubmitWordButton__Click(object sender, EventArgs e)
        {
            InputAnswer(this.wordResponseTextBox.Text.ToLower());
            this.submitWordButton.Enabled = false;
            this.wordResponseTextBox.Text = "";
            this.wordResponseTextBox.Enabled = false;
        }

        private void WordResponseTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (wordProblemsCompleted < 5 && e.KeyChar.ToString().ToLower() == "p")
            {
                e.Handled = true;
                this.submitWordButton.PerformClick();
                MessageBox.Show("The cube hates the letter 'p'. use a 'b' if you need to", "From: the chair", MessageBoxButtons.OK);
            }
            this.wordResponseTextBox.Text = Program.randCap(this.wordResponseTextBox.Text);
            this.wordResponseTextBox.SelectionStart = this.wordResponseTextBox.Text.Length;
            this.wordResponseTextBox.SelectionLength = 0;
        }

        private void QTimer__Tick(object sender, EventArgs e)
        {
            this.qToolStripProgressBar.Value--;

            if  (this.qToolStripProgressBar.Value == 0)
            {
                this.qTimer.Stop();
                if (num)
                {
                    this.keyPad.Close();
                }
                else
                {
                    this.submitWordButton.Enabled = false;
                    this.wordResponseTextBox.Enabled = false;
                    this.wordResponseTextBox.Text = "";
                }
                InputAnswer("OUTOFTIME");
            }
        }


        public void NewQuestion()
        {
            this.rightWrongLabel.Visible = false;
            int numOrWord = random.Next(0, 2);
            if (wordProblemsCompleted < wordProblems.Count && numOrWord == 0)
            {
                num = false;
            }
            else if (numProblemsCompleted < numProblems.Count && numOrWord == 1)
            {
                num = true;
            }

            if (num && numProblems.Count > 0)
            {
                currentProblem = numProblems[0];

                keyPad = new KeyPadForm(this);
                keyPad.Show();
                if (numProblemsCompleted == 3)
                {
                    // Thrembo Mode!!!
                    thremboMode = true;
                }
                if (numProblemsCompleted == 2)
                {
                    // start swapping buttons
                    keyPad.SwapButtons(numProblemsCompleted);
                }
            }
            else if (wordProblems.Count > 0)
            {
                currentProblem = wordProblems[0];

                this.submitWordButton.Enabled = true;
                this.wordResponseTextBox.Enabled = true;
            }

            this.qOutbputLabel.Text = currentProblem[0];
            this.qToolStripProgressBar.Value = 30;
            this.qTimer.Start();
        }

        public void InputAnswer(string ans)
        {
            if (ans == currentProblem[1])
            {
                this.rightWrongLabel.Text = "CORRECT!";
                this.rightWrongLabel.ForeColor = Color.Green;

                if (num)
                {
                    numProblemsCompleted++;
                    numProblems.Remove(currentProblem);
                }
                else
                {
                    wordProblemsCompleted++;
                    wordProblems.Remove(currentProblem);
                }

                if (numProblemsCompleted + wordProblemsCompleted == numOfRiddles)
                {
                    MessageBox.Show("Thank you for solving my riddles. Im sorry if they were any trouble." +
                        "You can enable the chair's glupp now...", "From: The Cube", MessageBoxButtons.OK);
                    parent.cubeRiddlesComplete = true;
                    this.Close();
                }
            }
            else
            {
                if (ans == "OUTOFTIME") { this.rightWrongLabel.Text = "OUT OF TIME!"; }
                else { this.rightWrongLabel.Text = "WRONG!"; }
                this.rightWrongLabel.ForeColor = Color.Red;
                parent.DecreaseHappiness(1000);
            }

            parent.cubeTime = 100;
            this.rightWrongLabel.Visible = true;
            this.qTimer.Stop();
            this.qToolStripProgressBar.Value = 30;
        }
    }
}
