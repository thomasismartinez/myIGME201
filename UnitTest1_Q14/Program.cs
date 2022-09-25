using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY
            // compile-time: missing semi-colon
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.);
            // compile-time: missing "" in string output
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine();
                // compile-time: sNumber isn't assigned
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            //} while (int.TryParse(sNumber, out nX));
            // compile-time: nY isn't assigned
            // logic: loop should only occur when try fails
            } while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}");
            // logic: string interpolation requires '$' before string
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }


        //int Power(int nBase, int nExponent)
        // compile-time: Power() must be static to be called in main method
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0;
                // logic: should return 1
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1);
                // run-time: Stack Overflow because nExponent is increases and never reaches the bas ecase of 0
                // logic: nExponent needs to decrement
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal;
            //compile-time: missing return keyword in return statement
            return returnVal;
        }
    }
}
