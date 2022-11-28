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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // president radio buttons
            
            this.bhRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.fdrRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.wjcRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.jbRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.fpRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.gwbRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.boRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.jfkRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.wmkRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.rrRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.ddeRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.mvbRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.gwRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.jaRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.trRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);
            this.tjRadioButton.CheckedChanged += new EventHandler(RadioButton__Check);

            //president text boxes


            //filter buttons

            //picture box

            this.exitButton.Click += new EventHandler(ExitButton__Click);
        }

        // president radio buttons

        private void RadioButton__Check(object sender, EventArgs e)
        {
            RadioButton presidentButton = (RadioButton)sender;
            // check if this is the active president button
            if (presidentButton.Checked)
            {
                // reformat names for browsing
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

                // set portrait to new President

               this.portraitPictureBox.Image = "" + ".png";


                // set web browser to president
                this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/" + wikiName;
                this.webBrowser.Navigate(new Uri("https://en.m.wikipedia.org/wiki/" + wikiName));
            }
        }


private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
