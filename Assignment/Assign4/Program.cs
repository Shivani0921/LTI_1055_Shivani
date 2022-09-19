using System;

namespace Assign4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members("Camilla", "Shawn", "Emilly", "Diana", "Shivani", "Bhavana", "Likitha", "Vikram", "Kiruthika");

        }
        public static void Members(params string[] names)
        {
            Array.Sort(names);
            foreach (string n in names)
            {

                Console.WriteLine(" Name :" + n);

            }

        }
    }
}



