﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml;

namespace Dyscord
{
    public delegate void UpdateConversationDelegate(string text);

    public partial class DyscordForm : Form
    {
    string targetUser = ""; // the username to communicate with
 	string targetIp = ""; // the ip address of the user to communicate with
    int targetPort; // the port of the user to communicate with
    string myIp = ""; // your ip address
    int myPort = 2222; // my listener port
    Thread thread;
 	Socket listener;

        public DyscordForm()
        {
            InitializeComponent();

            this.Show();
            SettingsForm settingsForm = new SettingsForm(this, myPort);
            settingsForm.ShowDialog();
            myPort = settingsForm.myPort;

            ThreadStart threadStart = new ThreadStart(Listen);
            thread = new Thread(threadStart);
            thread.Start();

            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress iPAddress in ipHost.AddressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.myIp = iPAddress.ToString();
                    break;
                }
            }

            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.usersButton.Click += new EventHandler(UsersButton__Click);
            this.sendButton.Click += new EventHandler(SendButton__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);

            this.FormClosing += new FormClosingEventHandler(Form__FormClosing);
        }

        private void LoginButton__Click(object sender, EventArgs e)
        {
            if (userTextBox.TextLength > 0)
            {
                webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?logins" + 
                    userTextBox.Text + "&ip=" + myIp + ":" + myPort);
            }
            webBrowser1.Visible = false;
            userTextBox.Enabled = false;
            loginButton.Enabled = false;
        }

        private void UsersButton__Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?logins");
            webBrowser1.Visible = true;
            convRichTextBox.SendToBack();
        }

        private void SendButton__Click(object sender, EventArgs e)
        {
            if (this.targetIp.Length > 0)
            {
                IPAddress iPAddress = IPAddress.Parse(this.targetIp);
                IPEndPoint remoteEndPoint = new IPEndPoint(iPAddress, this.targetPort);

                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(remoteEndPoint);
                Stream netStream = new NetworkStream(server);
                StreamWriter writer = new StreamWriter(netStream);

                string msg = userTextBox.Text + ": " + messageRichTextBox.Text;
                writer.WriteLine(msg.ToCharArray(), 0, msg.Length);

                writer.Close();
                netStream.Close();
                server.Close();

                this.convRichTextBox.Text += "> " + this.targetUser + ": " + messageRichTextBox.Text + "\n";

                this.messageRichTextBox.Clear();
            }
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            listener.Close();
            thread.Abort();

            Application.Exit();
        }

        private void Form__FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Close();
            thread.Abort();
        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlElementCollection;
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement htmlElement in htmlElementCollection)
            {
                htmlElement.Click += new HtmlElementEventHandler(HtmlElement__Click);
            }
        }

        private void HtmlElement__Click(object sender, HtmlElementEventArgs e)
        {
            string title;
            string[] ipPort;

            HtmlElement htmlElement = (HtmlElement)sender;

            title = htmlElement.GetAttribute("title");
            ipPort = title.Split(':');
            this.targetIp = ipPort[0];
            this.targetPort = Int32.Parse(ipPort[1]);

            this.targetUser = htmlElement.GetAttribute("name");
            this.groupBox1.Text = "Conversing with " + targetUser;

            webBrowser1.Visible = false;
            webBrowser1.SendToBack();
        }

        private void UpdateConversation(string text)
        {
            this.convRichTextBox.Text += text + "\n";
        }

        private void Listen()
        {
            UpdateConversationDelegate updateConversationDelegate;
            updateConversationDelegate = new UpdateConversationDelegate(UpdateConversation);

            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, this.myPort);

            this.listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(serverEndPoint);
            listener.Listen(300);

            while(true)
            {
                Socket client = listener.Accept();
                Stream netStream = new NetworkStream(client);
                StreamReader reader = new StreamReader(netStream);
                string result = reader.ReadToEnd();
                Invoke(updateConversationDelegate, result);
                reader.Close();
                netStream.Close();
                client.Close();
            }
        }
    }
}
