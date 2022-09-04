using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoordStart, imagCoordStart;
            double realCoordEnd, imagCoordEnd;
            double realIncrement, imagIncrement;
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            while (true)
            {
                //ask for each coordinate inputed in decimal terms
                Console.WriteLine("Please input start and end values for x and y.\n" +
                    "* decimal values between -2.0 and 2.0\n" +
                    "* x start must be less than x end\n" +
                    "* y start must be greater than y end\n");

                //input x start
                Console.WriteLine("x start:");
                realCoordStart = Double.Parse(Console.ReadLine());

                //input x end
                Console.WriteLine("x end:");
                realCoordEnd = Double.Parse(Console.ReadLine());

                //input y start
                Console.WriteLine("y start");
                imagCoordStart = Double.Parse(Console.ReadLine());

                //input y end
                Console.WriteLine("y end");
                imagCoordEnd = Double.Parse(Console.ReadLine());

                //check for valid inputs
                if ( (imagCoordStart > imagCoordEnd) && (realCoordStart < realCoordEnd) )
                {
                    //move on from input
                    break;
                }
                //else reapet query
            }

            //calculate proper increments
            realIncrement = (realCoordEnd - realCoordStart) / 80;
            imagIncrement = (imagCoordStart - imagCoordEnd) / 48;

            //iterate from y start to y end (48 increments)
            for (imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= imagIncrement)
            {
                //iterate from x start to x end (80 increments)
                for (realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += realIncrement)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
