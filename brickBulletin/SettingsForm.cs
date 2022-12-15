using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Timothy Wu

namespace brickBulletin
{
    public partial class SettingsForm : Form
    {
        /*
        HomeForm homeForm;
        Login loginForm;
        PostCreationForm postCreationForm;
        PostDialogue postDialogue;
        SearchForm searchForm;
        Signup signupForm;
        */

        public SettingsForm()
        {
            InitializeComponent();
            this.darkThemeCheckBox.CheckedChanged += new EventHandler(DarkThemeCheckBox__CheckedChanged);
            this.defaultFontSizeRadioButton.CheckedChanged += new EventHandler(DefaultFontSizeRadioButton__CheckedChanged);
            this.largeFontSizeRadioButton.CheckedChanged += new EventHandler(LargeFontSizeRadioButton__CheckedChanged);

            /*
            homeForm = new HomeForm();
            loginForm = new Login();
            postCreationForm = new PostCreationForm();
            postDialogue = new PostDialogue();
            searchForm = new SearchForm(homeForm);
            signupForm = new Signup();
            */
        }

        private void DarkThemeCheckBox__CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            Color bgDarkColor = Color.FromArgb(00, 00, 00);
            Color bgDefaultColor = Color.FromArgb(255, 255, 255);

            Color textDefaultColor = Color.FromArgb(00, 00, 00);
            Color textDarkColor = Color.FromArgb(208, 211, 212);

            if (cb.Checked == true)
            {
                Program.BackColor = bgDarkColor;
                Program.ForeColor = textDarkColor;

                /*
                //Settings form
                this.BackColor = bgDarkColor;
                this.darkThemeCheckBox.ForeColor = textDarkColor;
                this.settingsGroupBox.BackColor = bgDarkColor;
                this.settingsGroupBox.ForeColor = textDarkColor;
                this.defaultFontSizeRadioButton.ForeColor = textDarkColor;
                this.largeFontSizeRadioButton.ForeColor = textDarkColor;

                //Homepage Form
                this.homeForm.BackColor = bgDarkColor;
                this.homeForm.ForeColor = textDarkColor;

                //Search form
                this.searchForm.BackColor = bgDarkColor;
                this.searchForm.ForeColor = textDarkColor;

                //Post Dialouge form
                this.postDialogue.BackColor = bgDarkColor;
                this.postDialogue.ForeColor = textDarkColor;

                //Post Creation form
                this.postCreationForm.BackColor = bgDarkColor;
                this.postCreationForm.ForeColor = textDarkColor;
                
                //Login form
                this.loginForm.BackColor = bgDarkColor;
                this.loginForm.ForeColor = textDarkColor;
               
                //Sign-up form
                this.signupForm.BackColor = bgDarkColor;
                this.signupForm.ForeColor = textDarkColor;
                */
            }

            else
            {
                Program.BackColor = bgDefaultColor;
                Program.ForeColor = textDefaultColor;

                /*
                //Settings form
                this.BackColor = bgDefaultColor;
                this.darkThemeCheckBox.ForeColor = textDefaultColor;
                this.settingsGroupBox.BackColor = bgDefaultColor;
                this.settingsGroupBox.ForeColor = textDefaultColor;
                this.defaultFontSizeRadioButton.ForeColor = textDefaultColor;
                this.largeFontSizeRadioButton.ForeColor = textDefaultColor;

                //Homepage Form
                this.homeForm.BackColor = bgDefaultColor;
                this.homeForm.ForeColor = textDefaultColor;

                //Search form
                this.searchForm.BackColor = bgDefaultColor;
                this.searchForm.ForeColor = textDefaultColor;

                //Post Dialogue form
                this.postDialogue.BackColor = bgDefaultColor;
                this.postDialogue.ForeColor = textDefaultColor;

                //Post Creation form
                this.postCreationForm.BackColor = bgDefaultColor;
                this.postCreationForm.ForeColor = textDefaultColor;

                //Login form
                this.loginForm.BackColor = bgDefaultColor;
                this.loginForm.ForeColor = textDefaultColor;

                //Sign-up form
                this.signupForm.BackColor = bgDefaultColor;
                this.signupForm.ForeColor = textDefaultColor;
                */
            }
        }

        private void DefaultFontSizeRadioButton__CheckedChanged(object sender, EventArgs e)
        {
      
            int normalSize = Convert.ToInt32(8.25);

            //Settings form
            this.darkThemeLabel.Font = new Font("MS Sans Serif", normalSize, FontStyle.Regular);
            this.darkThemeCheckBox.Font = new Font("MS Sans Serif", normalSize, FontStyle.Regular);

            this.defaultFontSizeRadioButton.Font = new Font("MS Sans Serif", normalSize, FontStyle.Regular);
            this.largeFontSizeRadioButton.Font = new Font("MS Sans Serif", normalSize, FontStyle.Regular);
            this.fontSizeLabel.Font = new Font("MS Sans Serif", normalSize, FontStyle.Regular);

            Program.homepageSize = Convert.ToInt32(7.8);
            Program.postDialogueSize = Convert.ToInt32(9.75);
            Program.postCreationSize = Convert.ToInt32(12);
            Program.normalSize = Convert.ToInt32(7.8);

            /*
            //Homepage form
            int homepageNormalSize = Convert.ToInt32(7.8);
            this.homeForm.Font = new Font("Arial", homepageNormalSize, FontStyle.Regular);

            //Search form
            this.searchForm.Font = new Font("MS Sans Serif", normalSize, FontStyle.Regular);

            //Post Dialogue form
            int postDialogueNormalSize = Convert.ToInt32(9.75);
            this.postDialogue.Font = new Font("MS Sans Serif", postDialogueNormalSize, FontStyle.Regular);

            //Post Creation form
            int postCreationNormalSize = Convert.ToInt32(12);
            this.postCreationForm.Font = new Font("Arial", postCreationNormalSize, FontStyle.Regular);

            //Login form
            this.loginForm.Font = new Font("MS Sans Serif", normalSize, FontStyle.Regular);

            //Sign-up form
            this.signupForm.Font = new Font("MS Sans Serif", normalSize, FontStyle.Regular);
            */

        }
        private void LargeFontSizeRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            int largeSize = Convert.ToInt32(12.25);

            //Settings form
            this.darkThemeLabel.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);
            this.darkThemeCheckBox.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);

            this.fontSizeLabel.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);
            this.defaultFontSizeRadioButton.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);
            this.largeFontSizeRadioButton.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);

            Program.homepageSize = Convert.ToInt32(12.25);
            Program.postDialogueSize = Convert.ToInt32(12.25);
            Program.postCreationSize = Convert.ToInt32(12.25);
            Program.normalSize = Convert.ToInt32(12.25);

            /*
            //Homepage form
            this.homeForm.Font = new Font("Arial", largeSize, FontStyle.Regular);

            //Search form
            this.searchForm.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);

            //Post Dialogue form
            this.postDialogue.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);

            //Post Creation form
            this.postCreationForm.Font = new Font("Arial", largeSize, FontStyle.Regular);

            //Login form
            this.loginForm.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);

            //Sign-up form
            this.signupForm.Font = new Font("MS Sans Serif", largeSize, FontStyle.Regular);
            */
        }
    }
}
