using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTest1_Q3
{
    /// <summary>
    /// Class: Program
    /// Author: Thomas Martinez
    /// Purpose: Unit Test 1 Question 3
    /// Restrictions: None
    /// </summary>
    static internal class Program
    {
        /// <summary>
        /// Method: Main
        /// Purpose: Recreation of 3questions.exe
        /// Restrictions: None
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // variable to store question number
            int qNumber = 0;

            // string to store question
            string question = "";

            // string to store correct answer
            string correctAnswer;

            // store user input
            do
            {
                // prompt user to choose question
                Console.WriteLine("Choose your question (1-3):");

                // string input from user
                string qNumberStr = Console.ReadLine();

                // validate user input
                try
                {
                    int intInput = Int32.Parse(qNumberStr);
                    if (intInput < 1 || intInput > 3)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        // if input is valid then store it
                        qNumber = intInput;
                    }
                }
                catch
                {
                    continue;
                }
            }
            while (qNumber == 0);

            // output question and set correct answer based on user choice
            switch (qNumber)
            {
                case 1:
                    question = "What is your favorite color?";
                    correctAnswer = "black";
                    break;
                case 2:
                    question = "What is the answer to life, the universe and everything?";
                    correctAnswer = "42";
                    break;
                case 3:
                    question = "What is the airspeed velocity of an unladen swallow?";
                    correctAnswer = "What do you mean? African or European swallow?";
                    break;
            }

            // start timer
            Console.WriteLine("You have 5 seconds to answer the following question:");

            // question user
            Console.WriteLine(question);
        }
    }
}

