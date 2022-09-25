using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1_Q12
{
    /// <summary>
    /// Class: Program
    /// Author: Thomas Martinez
    /// Purpose: Unit Test 1 Question 12
    /// Restrictions: None
    /// </summary>
    static internal class Program
    {
        /// <summary>
        /// Method: Main
        /// Purpose: 
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declare variables
            string sName;
            double dSalary = 30000;

            // get user's name
            Console.WriteLine("What is your name?");
            sName = Console.ReadLine();

            if (GiveRaise(sName, ref dSalary) ) {
                Console.WriteLine("Congratulations on your raise!\nYour new salary is: $" + dSalary);
            }
            else
            {
                Console.WriteLine("Your salary is: $" + dSalary);
            }
            
        }

        static bool GiveRaise(string name, ref double salary)
        {
            if (name == "Thomas")
            {
                salary += 19999.99;
                return true;
            }
            return false;
        }
    }
}
