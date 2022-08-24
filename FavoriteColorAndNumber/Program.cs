using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteColorAndNumber
{
    namespace Color
    {
        static public class ColorClass
        {
            public static string sFavColor;
        }
    }
    namespace Number
    {
        static public class NumberClass
        {
            public static string nFavNumber;
        }
    }

    using CAlias = FavoriteColorAndNumber.Color

    internal class Program
    {
        /*
         * Method: Main
         * Purpose: Prompt the user for their favorite color and number
         *      Output their their favorite color (in limited text colors) their favorite number of times
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            string sFavColor = null;
            sFavColor = "";
            sFavColor = sFavColor.ToUpper();

            int? nFavNumber = null;

            //prompt user for their favorite color
            System.Console.Write("Enter your favorite color:\t");

            //get the user's input and store it in a variable
            //Console.ReadLine();

            Color.ColorClass.sFavColor = System.Console.ReadLine();

            //promp the user for their favorite number
            System.Console.Write("Enter your favorite number:\t");

            do
            {
                try
                {
                    //get the user's input and store it in a variable
                    Number.NumberClass.nFavNumber = Convert.ToInt32(System.Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter an interger");
                }
            } while (nFavNumber == null);
            //validate that the user entered a valid number

            //change the output text color to match their favorite color
            switch(sFavColor.ToLower()
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }

            //output their favorite color the number of times as their favorite number
            for (int i = 0; i < Number.NumberClass.nFavNumber; i++)
            {
                //System.Console.WriteLine("Your favorite color is " + sFavColor + "!");
                System.Console.WriteLine($"Your favorite color is {Color.ColorClass.sFavColor}!");
            }
        }
    }
}
