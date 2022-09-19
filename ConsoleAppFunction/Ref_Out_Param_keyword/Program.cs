using System;

namespace Ref_Out_Param_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 100, y = 200;
            //Console.WriteLine("Before Swap :x = " + x + "y = " + y);
            //Swap(ref x, ref y);
            //Console.WriteLine("After Swap :x = " + x + " y = " + y);
            //double Ar;
            //int radius;
            //Console.WriteLine("Enter Radius:");
            //radius = Convert.ToInt16(Console.ReadLine());
            //Area(ref radius, out Ar);
            //Console.WriteLine("Area of Circle ={0:f2}",Ar);
            //Console.ReadKey();
            Members(1055, "Bob", "Camilla", "Shawn", "Emilly","Mary");
            Members(1056, "A", "B", "C", "D", "E");
        }
        //public static void Swap(int a, int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        //ref keyword is used to get access to memory location
        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        ////ref and out keyword
        //public static void Area(ref int r, out double A)
        //{
        //    A= Math.PI*r*r;
        //}
        
        //params keyword is used to pass an array of undecided length as a parameter
        public static void Members(int branchcode,params string[] names )
        {
            Console.WriteLine("Branch code is " +branchcode);
            foreach(string n in names)
            {
                Console.WriteLine("name:" + n);
            }
        }

    }
}
