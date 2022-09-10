using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_MadLibs
{
    /// <summary>
    /// Class: Program
    /// Author: Thomas Martinez
    /// Purpose: Mad Libs Exercise
    /// Restrictions: None
    /// </summary>
    static internal class Program
    {
        /// <summary>
        /// Class: Main
        /// Purpose:
        /// Restrictions: None
        /// </summary>
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;
            string resultString = "";

            StreamReader input;

            //open template file to see how many lubs are in it
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            //close template file
            input.Close();

            //allocate as many strings as there are madlibs
            string[] madLibs = new string[numLibs];

            //read the Mad Libs into an array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                //set this array element to the current line of the template file
                madLibs[cntr] = line;

                //replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            //ask the user if they would like to play Mad Libs
            Console.WriteLine("Would you like to play Mad Libs");
            string yesNo = null;

            //loop until a valid response is given
            while (yesNo == null)
            {
                //if the input is neither yes or no than try prompting again
                yesNo = Console.ReadLine().ToLower();
                if (yesNo != "yes" && yesNo != "no")
                {
                    Console.WriteLine("You Must input either the word \"yes\" or \"no\"");
                    yesNo = null;
                }
            }


            //if answer is "yes" then play Mad Libs
            if (yesNo == "yes")
            {
                //prompt the user for which Mad Lib they would like ot play (nChoice)
                Console.WriteLine("Which Mad Lib would you like to play? (1 through " + (madLibs.Length - 1) + ")");
                while (true)
                {
                    //if input is valid parse it to int nChoice
                    try
                    {
                        nChoice = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    //if input is invalid give error messege and try again
                    catch
                    {
                        Console.WriteLine("Input must be and integer between 1 and " + (madLibs.Length - 1));
                    }
                }

                //split the mad lib into sperate words
                string[] words = madLibs[nChoice].Split(' ');

                foreach (string word in words)
                {
                    //if word is a placeholder
                    if (word.StartsWith("{"))
                    {
                        //prompt the user for the replacement
                        Console.WriteLine("Please input a " + (word.Substring(1, word.Length - 2)).Replace('_', ' '));

                        //and append the user response to the result string
                        resultString += Console.ReadLine() + " ";
                    }
                    //else append word the the result string
                    else
                    {
                        resultString += word + " ";
                    }
                }

                //Print final result
                Console.WriteLine(resultString);
            }
        }
    }
}
