using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

    delegate double MyRound(double d, int i);
    static internal class Program
    {
        /// <summary>
        /// Method: Main
        /// Purpose: Impersonate Math.Round() with a delegate
        /// Restrictions: None
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyRound mr;

            mr = new MyRound(Math.Round);

            double result = mr(1.24343, 0);

            Console.WriteLine(result);
        }
    }
}
