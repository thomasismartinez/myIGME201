using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_VariablesAndExpressionsQ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generate array of 4 intergers
            int[] ints = new int[4];

            //prompt user for 4 interger inputs
            Console.WriteLine("Please input 4 interger values:");

            //iterate through index values of int[]
            for (int i = 0; i < 4; i++)
            {
                //loop if there is nothing stored
                while (ints[i] == 0)
                {
                    //try taking and storing user input until the spot in ints is filled
                    try
                    {
                        ints[i] = Convert.ToInt32(Console.ReadLine());

                        //escape loop if 0 is inputted by user
                        if (ints[i] == 0)
                        {
                            break;
                        }
                    }
                    //generate error message if the string cannot be parsed correctly
                    catch
                    {
                        System.Console.WriteLine("ERROR: Please input an interger value");
                    }
                }
            }
            //output product
            Console.WriteLine("Product is: " + (ints[0] * ints[1] * ints[2] * ints[3]));

            for (int i = 0; i < 3; i++)
            {
                Console.Write(5 / i);
            }

        }
    }
}
