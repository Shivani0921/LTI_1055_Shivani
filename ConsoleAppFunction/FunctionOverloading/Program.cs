using System;

namespace FunctionOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void Sum(int a, int b)
        {
            Console.WriteLine("{0} +{1}= {2}", a, b, (a + b));
        }
        public static void Sum(int a, int b, int c)
        {
            Console.WriteLine("{0} +{1} + {2}={3}", a, b, c, (a + b + c));
        }
        public static void Sum(int a, float b, int c)
        {
            Console.WriteLine("{0} +{1:f2} + {2}={3}", a, b, c, (a + b + c));
        }
        public static void Sum(int a, int b, float c)
        {
            Console.WriteLine("{0} +{1} + {2}={3}", a, b, c, (a + b + c));
        }
    }
}
