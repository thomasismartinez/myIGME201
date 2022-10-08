using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClassA A = new MyClassA();
            MyClassB B = new MyClassB();

            MyMethod(A);
            MyMethod(B);
        }

        public static void MyMethod(IMyInterface myObject)
        {
            myObject.MyMethod();
        }
    }

    public interface IMyInterface
    {
        void MyMethod();
    }

    public class MyClassA : IMyInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Class A used the method!");
        }
    }

    public class MyClassB : IMyInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Class B used the method!");
        }
    }
}
