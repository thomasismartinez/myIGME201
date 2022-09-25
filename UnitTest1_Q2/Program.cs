using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1_Q2
{
    /// <summary>
    /// Class: Program
    /// Author: Thomas Martinez
    /// Purpose: Unit Test #1 Question 2
    /// Restrictions: None
    /// </summary>
    static internal class Program
    {

        // the definition of the delegate function data type
        delegate string sortingFunction(string[] a);

        /// <summary>
        /// Method: Main
        /// Purpose: Sort words in a user input
        /// Restrictions: none
        /// </summary>

        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            string[] aUnsorted;
            string[] aSorted;

            // declare the delegate variable which will point to the function to be called
            sortingFunction findHiLow;

        // a label to allow us to easily loop back to the start if there are input issues
        start:
            Console.WriteLine("Enter a sentance with no punctuation");

            // read the space-separated string of numbers
            string sentance = Console.ReadLine();

            // split the string into the an array of strings which are the individual words
            string[] sWords = sentance.Split(' ');

            // initialize the size of the unsorted array to 0
            int nUnsortedLength = 0;

            // a double used for parsing the current array element
            string thisWord;

            // iterate through the array of word strings
            foreach (string sThisWord in sWords)
            {
                // if the length of this string is 0 (ie. they typed 2 spaces in a row)
                if (sThisWord.Length == 0)
                {
                    // skip it
                    continue;
                }

                try
                {
                    // try to parse the current string into a double
                    thisWord = sThisWord;

                    // if it's successful, increment the number of unsorted numbers
                    ++nUnsortedLength;
                }
                catch
                {
                    // if an exception occurs
                    // indicate which number is invalid
                    Console.WriteLine($"Word #{nUnsortedLength + 1} is not a valid word.");

                    // loop back to the start
                    goto start;
                }
            }

            // now we know how many unsorted words there are
            // allocate the size of the unsorted array
            aUnsorted = new string[nUnsortedLength];

            // reset nUnsortedLength back to 0 to use as the index to store the numbers in the unsorted array
            nUnsortedLength = 0;
            foreach (string sThisWord in sWords)
            {
                // still skip the blank strings
                if (sThisWord.Length == 0)
                {
                    continue;
                }

                // parse it into a double (we know they are all valid now)
                thisWord = sThisWord;

                // store the value into the array
                aUnsorted[nUnsortedLength] = thisWord;

                // increment the array index
                nUnsortedLength++;
            }

            // allocate the size of the sorted array
            aSorted = new string[nUnsortedLength];

            // prompt for <a>scending or <d>escending
            Console.Write("Ascending or Descending? ");
            string sDirection = Console.ReadLine();

            if (sDirection.ToLower().StartsWith("a"))
            {
                findHiLow = new sortingFunction(FindLowestValue);
            }
            else
            {
                findHiLow = new sortingFunction(FindHighestValue);
            }

            // start the sorted length at 0 to use as sorted index element
            int nSortedLength = 0;

            // while there are unsorted values to sort
            while (aUnsorted.Length > 0)
            {
                // store the lowest or highest unsorted value as the next sorted value
                aSorted[nSortedLength] = findHiLow(aUnsorted);

                // remove the current sorted value
                RemoveUnsortedValue(aSorted[nSortedLength], ref aUnsorted);

                // increment the number of values in the sorted array
                ++nSortedLength;
            }

            // write the sorted array of numbers
            Console.WriteLine("The sorted list is: ");
            foreach (string thisNum in aSorted)
            {
                Console.Write($"{thisNum} ");
            }

            Console.WriteLine();
        }

        // find the lowest alphabetical value in the array of strings
        static string FindLowestValue(string[] array)
        {
            // define return value
            string returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (string thisWord in array)
            {
                // if the current value is less than the saved lowest value
                if (thisWord.CompareTo(returnVal) < 0)
                {
                    // save this as the lowest value
                    returnVal = thisWord;
                }
            }

            // return the lowest value
            return (returnVal);
        }

        static string FindHighestValue(string[] array)
        {
            // define return value
            string returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (string thisWord in array)
            {
                // if the current value is greater than the saved highest value
                if (thisWord.CompareTo(returnVal) > 0)
                {
                    // save this as the highest value
                    returnVal = thisWord;
                }
            }

            // return the highest value
            return (returnVal);
        }


        // remove the first instance of a value from an array
        static void RemoveUnsortedValue(string removeValue, ref string[] array)
        {
            // allocate a new array to hold 1 less value than the source array
            string[] newArray = new string[array.Length - 1];

            // we need a separate counter to index into the new array, 
            // since we are skipping a value in the source array
            int dest = 0;

            // the same value may occur multiple times in the array, so skip subsequent occurrences
            bool bAlreadyRemoved = false;

            // iterate through the source array
            foreach (string srcNumber in array)
            {
                // if this is the number to be removed and we didn't remove it yet
                if (srcNumber == removeValue && !bAlreadyRemoved)
                {
                    // set the flag that it was removed
                    bAlreadyRemoved = true;

                    // and skip it (ie. do not add it to the new array)
                    continue;
                }

                // insert the source number into the new array
                newArray[dest] = srcNumber;

                // increment the new array index to insert the next number
                ++dest;
            }

            // set the ref array equal to the new array, which has the target number removed
            // this changes the variable in the calling function (aUnsorted in this case)
            array = newArray;
        }
    }
}
