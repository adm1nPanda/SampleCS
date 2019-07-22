using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sample
{
    class Program
    {

        private static int Add(int a, int b)
        {
            return a + b;
        }

        public static string Hidden(string[] a1)
        {
            Console.WriteLine("running hidden function in program");

            return a1.Length.ToString();
            
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("This a sample program build with .NET 3.5");
            Console.WriteLine("Attempting to perform some basic function calls and arithmatic operations");

            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(3, 13));
            Console.WriteLine(Add(2345, 233));
            Console.WriteLine(Add(2124, 34213));
            

        }
    }
}
