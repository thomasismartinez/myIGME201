using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            //missing semi-colon but is also unnecessary because it can be created by the for loop instead

            // declare string to hold all numbers
            string allNumbers = null;
            // allNumbers must be declared here so that is can be accessed outside of the loop

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)
            for (double i = 1; i <= 10; ++i)
                // "i < 10" should be "i <= 10" so that the number 10 is included in the calculations
                // declaring  i in the loop is more efficiant
                // making i a double allows for division by zero
            {
                // declare string to hold all numbers
                // string allNumbers = null;
                // allNumber must be created outside of the for loop in order for it to be accessed outside of the loop
                

                // output explanation of calculation
                // Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = ");
                // without parenthasese the program tries to calculate "i / i" - 1 which is causes a compile time error

                // output the calculation based on the numbers
                Console.WriteLine(i / (i - 1));
                // originally needed a try catch to keep it from dividing by zero but switching
                //      i from an int to a double allows division by zero


                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1;
                //unnecessary because of the for loop
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
            // the string and the variable were not properly concatonated
        }
    }
}
