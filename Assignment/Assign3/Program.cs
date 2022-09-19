using System;

namespace Assign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            area(5);
            area(3, 6);
            area(8, 1.5f);
        }
        public static void area(int r)
        {
            double Res = Math.PI * r * r;
            Console.WriteLine("Area of circle= {0:f2}",  Res);
        }
        public static void area(int l, int b)
        {
            int Res = l * b;
            Console.WriteLine("Area of Rectangle= " + Res);
        }
        public static void area(int b, float h)
        {
            double Res = 0.5 * b * h;
            Console.WriteLine("Area of Triangle= {0:f2} " , Res);
        }
    }
}