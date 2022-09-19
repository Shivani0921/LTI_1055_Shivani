using System;

namespace InheritanceExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Daughter d1 = new Daughter();
            Console.WriteLine(d1);

            Daughter d2 = new Daughter("Mohini", 15, "Kiruthika", 45);
            Console.WriteLine(d2);
        }
    }
}
