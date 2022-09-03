using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_FlowControl
{
    // Class: Program
    // Author: Thomas Martinez
    // Purpose: PE4 Exercise 2
    // Restrictions: None
    internal class Program
    {
        // Class Program
        // Purpose: Take two int values from user input and output them again 
        //          if either in greater than 10 but not both of them.
        // Restrictions: None
        static void Main(string[] args)
        {
            //store two int variables
            int var1;
            int var2;
            //loop until user input meets repuired operation output
            while (true)
            {
                Console.WriteLine("Please input 2 values. One must be greater that 10 and the other must be less than 10");
                var1 = Int32.Parse(Console.ReadLine());
                var2 = Int32.Parse(Console.ReadLine());
                //set boolean values for if var1 > 10 and if var2 > 10
                bool operand1 = var1 > 10;
                bool operand2 = var2 > 10;
                //check if either operand1 and operand2 are true and ensure that both aren't true at the same time
                if ((operand1 || operand2) && !(operand1 && operand2))
                {
                    //if user input passes than leave the loop and don't output and error
                    break;
                }
                //if not, display a red error messege and loop again
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //Output what the user has inputed and make just the values green
            Console.Write("You have inputed: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(var1 + ", " + var2);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
