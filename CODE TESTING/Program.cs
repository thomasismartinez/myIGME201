using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_TESTING
{
    static class Program
    {
        static void Main()
        {
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            friendBirthdays.Add("Thomas", new DateTime(2003, 7, 17));
            friendBirthdays.Add("Andrew", new DateTime(2002, 11, 21));
            //(use the format string "MM/dd/yyyy" in your output)

            foreach (KeyValuePair<string, DateTime> bDay in friendBirthdays)
            {
                Console.WriteLine(bDay.Key + "'s birthday is: " + bDay.Value.ToString("MM/dd/yyyy"));
            }
        }
    }

}
