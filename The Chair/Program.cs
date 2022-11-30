using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Chair
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChairForm());
        }

        // Randomize Capitalization
        public static string randCap(string phrase)
        {
            Random rand = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            int n;
            foreach (Char letter in phrase)
            {
                n = rand.Next(100);
                if (n < 50)
                {
                    stringBuilder.Append(letter.ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(letter.ToString().ToLower());
                }
            }

            return stringBuilder.ToString();
        }
    }
}
