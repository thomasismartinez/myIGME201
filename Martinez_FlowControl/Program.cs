using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1;
            int var2;
            while (true)
            {
                Console.WriteLine("Please input 2 values. One must be greater that 10 and the other must be less than 10");
                var1 = Int32.Parse(Console.ReadLine());
                var2 = Int32.Parse(Console.ReadLine());
                bool operand1 = var1 > 10;
                bool operand2 = var2 > 10;
                bool result = (operand1 || operand2) && !(operand1 && operand2);
                if ((operand1 || operand2) && !(operand1 && operand2))
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("You have inputed: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(var1 + ", " + var2);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
