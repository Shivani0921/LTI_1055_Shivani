using System;

namespace Assign2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Ar;
            int base1;
            int height;
            Console.WriteLine("Enter base: ");
            base1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            height = Convert.ToInt16(Console.ReadLine());
            Area(ref base1, ref height, out Ar);
            Console.WriteLine("Area of triangle= {0:f2}", Ar);
            Console.ReadKey();
        }
        public static void Area(ref int b, ref int h, out double A)
        {
            A = 0.5 * b * h;
        }
    }
}