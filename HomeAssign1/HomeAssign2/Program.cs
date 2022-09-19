using System;

namespace HomeAssign2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medi m1 = new Medi();
            Console.WriteLine(m1);
            Medi m2 = new Medi(2, "Dolo-650", "Antibiotic", 8.50f, new DateTime(2022, 11, 11), Category.C);
            Console.WriteLine(m2);
        }
    }
}
