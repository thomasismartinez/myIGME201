using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Functions3
{
    /// <summary>
    /// Class: Program
    /// Author: Thomas Martinez
    /// Purpose: PE9 Question 3
    /// Restrictions: None
    /// </summary>
    static internal class Program
    {
        /// <summary>
        /// Method: Main
        /// Purpose: Delegate function to impersonate Console.ReadLine()
        /// Restrictions: None
        /// </summary>

        public delegate string MethodPtr();
        static void Main(string[] args)
        {
            MethodPtr pointer = new MethodPtr(Console.ReadLine);

            Console.WriteLine("please give any input");
            string input = pointer.Invoke();
            Console.WriteLine("you inputted: " + input);
        }
    }
}
