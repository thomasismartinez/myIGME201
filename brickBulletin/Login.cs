﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brickBulletin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.usernameTextBox.Validating += new CancelEventHandler(UsernameTextBox__Validating);
            this.passwordTextBox.Validating += new CancelEventHandler(PasswordTextBox__Validating);

            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.signupButton.Click += new EventHandler(SignupButton__Click);
            this.guestButton.Click += new EventHandler(GuestButton__Click);
        }

        private void UsernameTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text == "")
            {
                this.userErrorProvider.SetError(textBox, "Please enter your username");
                e.Cancel = true;
            }
            else
            {
                this.userErrorProvider.SetError(textBox, null);
                e.Cancel = false;
            }
        }

        private void PasswordTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                this.passErrorProvider.SetError(textBox, "Please enter your password");
                e.Cancel = true;
            }
            else
            {
                this.passErrorProvider.SetError(textBox, null);
                e.Cancel = false;
            }
        }

        private void LoginButton__Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SignupButton__Click(object sender, EventArgs e)
        {
            Signup signupPage = new Signup();
            signupPage.ShowDialog();
        }

        private void GuestButton__Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}