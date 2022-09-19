using System;

namespace ConsoleAppFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling the functions
            sum(10, 5);
            sub(10, 5);
            mul(10, 5);
            div(b: 10, a: 5.5);
            Console.WriteLine();

            //calling named parameters
            namedparamter(age: 22, name: "Shivani");
            Console.WriteLine();

            //calling functions with default value
            sumofnums(5, 7);
            Console.WriteLine();
        }

        //Example for functions
        public static void sum(int a, int b)
        {
            Console.WriteLine("Sum=" + (a + b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("Sub=" + (a - b));
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine("mul=" + a * b);
        }
        public static void div(double a, double b)
        {
            Console.WriteLine("div=" + (a / b));
        }

        //Example for named parameters
        public static void namedparamter(string name, int age)
        {
            Console.WriteLine("Name:{0} Age:{1}", name, age);
        }

        //Example for creating functions with default parameters

        public static void sumofnums(int a, int b, int c = 10)
        {
            Console.WriteLine("Sum of numbers is :" + (a + b + c));
        }
    }
}