using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

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
        // bTimeOut boolean
        static bool bTimeOut = false;

        // timeOutTimer Timer
        static System.Timers.Timer timeOutTimer;

        /// <summary>
        /// Method: Main
        /// Purpose: Recreation of 3questions.exe
        /// Restrictions: None
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            start:

            // variable to store question number
            int qNumber = 0;

            // string to store question
            string question = "";

            // string to store correct answer
            string correctAnswer = "";

            // initialize timeout flag
            bTimeOut = false;

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

            while (!bTimeOut)
            {
                // initialize timer
                Console.WriteLine("You have 5 seconds to answer the following question:");
                timeOutTimer = new System.Timers.Timer(5000);
                timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

                // question user
                Console.WriteLine(question);

                // start the timeOutTimer
                timeOutTimer.Start();

                // read the user's attempt
                string sAnswer = Console.ReadLine();

                // stop the timeOutTimer
                timeOutTimer.Stop();

                // if they entered the correct answer and they didn't timeout
                if (sAnswer == correctAnswer && !bTimeOut)
                {
                    // output "Well done!"
                    Console.WriteLine("Well done!");
                    bTimeOut = true;
                }
                else
                {
                    // tell user why they failed
                    if (bTimeOut)
                    {
                        Console.WriteLine("Times up!");
                    }
                    else
                    {
                        Console.Write("Wrong!  ");
                    }
                    // display the correct answer
                    Console.WriteLine("The answer is: " + correctAnswer);

                    // set bTimeOut to true to exit the game loop
                    bTimeOut = true;
                }
            }

            bool quit = false;
            do
            {
                Console.Write("Play again? ");
                string again = Console.ReadLine();
                if (again.Substring(0,1).ToLower() == "y")
                {
                    goto start;
                }
                else if (again.Substring(0, 1).ToLower() == "n")
                {
                    quit = true;
                }
            } while (!quit);
        }

        static void TimesUp(object source, ElapsedEventArgs e)
        {

            // set the bTimeOut flag to quit the game
            bTimeOut = true;

            // stop the timeOutTimer
            timeOutTimer.Stop();
        }
    }
}

