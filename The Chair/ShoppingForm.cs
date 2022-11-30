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
    public partial class ShoppingForm : Form
    {
        List<Button> buttonList = new List<Button>();
        Random rand = new Random();
        int count = 1;
        ChairForm parent;
        int[] refRadioButtons;
        public ShoppingForm(ChairForm chairForm, ref int[] foodCountList)
        {
            InitializeComponent();

            parent = chairForm;
            refRadioButtons = foodCountList;

            // Add all shopping buttons to buttonList
            foreach (Control control in this.Controls)
            {
                try { buttonList.Add((Button)control); } catch { }
                control.Visible = false;
            }
            buttonList.Remove(exitButton);
            exitButton.Visible = true;

            // Add ShopButton__Click eventhandler to each shopping button
            this.button1.Click += new EventHandler(ShopButton__Click);
            this.button2.Click += new EventHandler(ShopButton__Click);
            this.button3.Click += new EventHandler(ShopButton__Click);
            this.button4.Click += new EventHandler(ShopButton__Click);
            this.button5.Click += new EventHandler(ShopButton__Click);
            this.button6.Click += new EventHandler(ShopButton__Click);
            this.button7.Click += new EventHandler(ShopButton__Click);
            this.button8.Click += new EventHandler(ShopButton__Click);
            this.button9.Click += new EventHandler(ShopButton__Click);
            this.button12.Click += new EventHandler(ShopButton__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // randomize store size
            int sizeVariable = rand.Next(100, 800);
            this.Size = new System.Drawing.Size(sizeVariable, 800 - sizeVariable);
            // Display 8 random shopping buttons in 8 random positions within the view
            for (int i = 8; i > 0; i--)
            {
                Button showButton = buttonList[rand.Next(buttonList.Count)];
                showButton.Visible = true;
                buttonList.Remove(showButton);
                showButton.Location = new 
                    System.Drawing.Point(rand.Next(sizeVariable/2), rand.Next((800 - sizeVariable)/2));
            }
            
        }

        private void ShopButton__Click(object sender, EventArgs e)
        {
            Button sb = (Button)sender;

            // if 4 or less buttons have been collected
            if (count < 6)
            {
                //hide button
                sb.Visible = false;
                // increase c
                count++;
                // add radio button count to parent's counts
                refRadioButtons[Int32.Parse(sb.Text)]++;
                //disable other buttons after 5 are collected
                if (count == 5)
                {
                    foreach (Button b in buttonList) { 
                        b.Enabled = false; // MAKE THIS WORK
                    }
                }
            }

            //randomize caps
            this.Text = Program.randCap(this.Text);
            this.exitButton.Text = Program.randCap(this.exitButton.Text);
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            // update Chair Form's counters
            parent.UpdateRadioButtonCount();
            // close form
            this.Close();
        }
    }
}
