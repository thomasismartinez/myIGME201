using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Martinez_HelloWorld
{
    /*
    Class: Program
    Author: Thomas Martinez
    Purpose: Introduction to C# programming
    Restrictions: This is my first time programming C#
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            Console.WriteLine("Hello World!");
            int number = 3;
            Console.WriteLine("int number has been set to 3");
            int digit = 4;
            Console.WriteLine("int digit has been set to 4");
            double dec = 3.0;
            Console.WriteLine("double decimal has been set to 3.0");
            digit = (int) dec;
            Console.WriteLine("int digit has been set the the casted value of dec");
            dec = 4;
            Console.WriteLine("double dec has been set to 4.0 (via implicit casting)");

            //while loop counts down number until it hits 0
            while (number > 0)
            {
                Console.WriteLine("number = " + number);
                //if else tells user weather the number is EVEN or ODD
                if ((number % 2) == 0)
                {
                    Console.WriteLine("NUMBER IS EVEN");
                }
                else
                {
                    Console.WriteLine("NUMBER IS ODD");
                }
                number--;
            }

            //user input prompt
            Console.WriteLine("Please input 6 words");
            //for loop takes word input 6 times, each time adding the new word/line to an ArrayList
            ArrayList words = new ArrayList();
            for (int i = 0; i < 6 ; i++)
            {
                words.Add(Console.ReadLine());
            }
            //iterates through ArrayList to display the users input in a comma'd list
            Console.Write("Thank you for writing: ");
            foreach (String word in words)
            {
                Console.Write(word + ", ");
            }

            Console.WriteLine("\npress 'enter' to close program");
            Console.ReadLine();
        }
    }
}
