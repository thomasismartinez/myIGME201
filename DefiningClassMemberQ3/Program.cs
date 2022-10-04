using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassMemberQ3
{
    /// <summary>
    /// Class: Program 
    /// Author: Thomas Martinez
    /// Purpose: PE12 Question 3
    /// Restrictions: None
    /// </summary>
    static internal class Program
    {
        /// <summary>
        /// Method: Main
        /// Purpose:
        /// Restrictions: None
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyDerivedClass myObject = new MyDerivedClass();
            myObject.MyString = "Hello";
            Console.WriteLine(myObject.GetString());
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString() {
            return MyString + " (output from the derived class)";
        }
    }

    public class MyClass
    {
        private string myString;

        public virtual string GetString()
        {
            return myString;
        }

        public string MyString
        {
            get { return myString; }
            set { myString = value; }
        }


    }

}
