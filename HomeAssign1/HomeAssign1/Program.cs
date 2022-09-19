using System;

namespace HomeAssign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product1 p = new Product1();
            Console.WriteLine(p);
            Product1 p1 = new Product1(2, "Keyboard", 10.50f, new DateTime(2022, 9, 2), Category.C);
            Console.WriteLine(p1);
        }
    }
}
