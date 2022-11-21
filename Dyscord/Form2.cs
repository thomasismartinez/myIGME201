using System;
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

namespace Dyscord
{
    public delegate void UpdateConversationDelegate(string text);

    public partial class DyscordForm : Form
    {
    string targetUser; // the username to communicate with
 	string targetIp; // the ip address of the user to communicate with
    int targetPort; // the port of the user to communicate with
    string myIp; // your ip address
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
