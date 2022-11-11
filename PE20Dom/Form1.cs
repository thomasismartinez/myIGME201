using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.webBrowser1.DocumentCompleted += new
                WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);


            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");
        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            // <h1> -> "My UFO Page"
            htmlElement = webBrowser1.Document.GetElementsByTagName("h1")[0];
            htmlElement.InnerText = "My UFO Page";

            // first <h2> -> "My UFO Info"
            htmlElement = webBrowser1.Document.GetElementsByTagName("h2")[0];
            htmlElement.InnerText = "My UFO Info";

            // second <h2> -> "My UFO Picture"
            htmlElement = webBrowser1.Document.GetElementsByTagName("h2")[1];
            htmlElement.InnerText = "My UFO Picture";

            // third <h2> -> ""
            htmlElement = webBrowser1.Document.GetElementsByTagName("h2")[2];
            htmlElement.InnerText = "";

            // <body> -> reddish, sans-seriff
            htmlElement = webBrowser1.Document.GetElementsByTagName("body")[0];
            htmlElement.Style = ("font-family: sans-serif; color: #DD5555;") ;

            // first <p> changes
            htmlElement = webBrowser.Document.GetElementsByTagName("p")[0];
            htmlElement.InnerHtml = "Report your UFO sightings <a href='http://www.nuforc.org'>here</a>"; 
            htmlElement.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; " +
                "text-shadow: 3px 2px #A44";

            // second <p> -> ""
            htmlElement = webBrowser.Document.GetElementsByTagName("p")[1];
            htmlElement.InnerText = "";

            // third <p> -> UFO img
            htmlElement = webBrowser.Document.GetElementsByTagName("p")[2];
            htmlElement.InnerHtml = "<img src='https://images.pexels.com/photos/5251883/pexels-photo-5251883.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'>";
            htmlElement.GetElementsByTagName("img")[0].Style = "height: 20em";

            // add footer
            htmlElement = webBrowser.Document.CreateElement("footer");
            htmlElement.InnerText = "&copy2022 Thomas Martinez";
            webBrowser1.Document.Body.AppendChild(htmlElement);
        }
    }
}
