using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    static internal class Program
    {
        public delegate double MyRounder(double d, int n);
        static void Main(string[] args)
        {
            // create variable of delegate function type 
            MyRounder myRounder;

            // your code here
            myRounder = new MyRounder(Math.Round);

            double result = myRounder(5.5, 0);

            Console.WriteLine(result);
        }
    }
}