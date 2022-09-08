using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Martinez_ParsingAndFormatting
{
    // Class: Program
    // Author: Thomas Martinez
    // Purpose: Parsing And Formatting Exercise
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: A game where the player has to guess a random number between 0 and 100
        // Restrictions: None
        static void Main(string[] args)
        {
            Random rand = new Random();
            ArrayList guessedValues = new ArrayList();

            //Generate random integer between 0 and 101 exclusively
            int randomNumber = rand.Next(0, 101);

            //testing print statement
            Console.WriteLine("Random Number: " + randomNumber);

            //user get 8 attempts to guess number correctly
            int turn;
            for (turn = 1; turn <= 9; turn++)
            {
                //if the 9th turn is reached the game ends and the player looses
                if (turn == 9)
                {
                    //output loss messege
                    Console.WriteLine("You ran out of turns! The number was " + randomNumber);
                    break;
                }

                int response;

                //loop until valid input is given
                while (true)
                {
                    //prompt user for a number
                    Console.Write("Turn " + turn + ": Enter your guess: ");

                    try
                    {
                        //parse input to an integer
                        response = Int32.Parse(Console.ReadLine());

                        //break loop if response in valid (integer between 0 and 100)
                        if (response > 0 && response < 100)
                        {
                            if (!guessedValues.Contains(response))
                            {
                                guessedValues.Add(response);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have already guessed " + response + ", try another value.");
                                
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    //output error messege if input is invalid
                    catch
                    {
                        Console.WriteLine("Invalid response - Response must be an integer between 0 and 100");
                    }
                }

                //check if input is greater than target
                if (response > randomNumber)
                {
                    //inform user
                    Console.WriteLine("Your guess is TOO HIGH");
                }
                //check if input is less than target
                else if (response < randomNumber)
                {
                    Console.WriteLine("Your guess is TOO LOW");
                }
                //if input is valid and is neither less than or greater than target than the player wins
                else
                {
                    Console.WriteLine("Your guess is CORRECT");
                    Console.WriteLine("It took you " + turn + " turns!");
                    break;
                }
            }
        }
    }
}