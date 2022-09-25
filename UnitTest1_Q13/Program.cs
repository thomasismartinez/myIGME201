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
    /// Purpose: Unit Test 1 Question 13
    /// Restrictions: None
    /// </summary>
    static internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }


        /// <summary>
        /// Method: Main
        /// Purpose: Give user a raise if they're name Thomas
        /// Restrictions: None
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declare variables
            employee user = new employee();
            user.dSalary = 30000;

            // get user's name
            Console.WriteLine("What is your name?");
            user.sName = Console.ReadLine();

            if (GiveRaise(user))
            {
                Console.WriteLine("Congratulations on your raise!\nYour new salary is: $" + user.dSalary);
            }
            else
            {
                Console.WriteLine("Your salary is: $" + user.dSalary);
            }

        }

        static bool GiveRaise(employee e)
        {
            if (e.sName == "Thomas")
            {
                e.dSalary += 19999.99;
                return true;
            }
            return false;
        }
    }
}
