using System;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5];
            fruits[0] = "Banana";
            fruits[1] = "Apple";
            fruits[2] = "Grapes";
            fruits[3] = "Orange";
            fruits[4] = "Mango";
            Console.WriteLine("Given Array is:");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(fruits[i]);
            foreach (string f in fruits)
            {
                Console.WriteLine(f);
            }
            int[] marks = { 12, 13, 14, 15, 16, 17, 18 };
            Console.WriteLine("Display of marks");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("marks:" + marks[i]);

                //array class methods 1-sort 2-reverse
                //foreach is only used to display data and not for taking input
                Array.Sort(fruits);
                Console.WriteLine(".....sorted order of fruits inn ascending order");
                foreach (string f in fruits)
                {
                    Console.WriteLine(f);
                }
                Array.Reverse(fruits);
                Console.WriteLine(".....sorted order of fruits in descending order");
                foreach (string f in fruits)
                {
                    Console.WriteLine(f);
                }
            }
        }
    }
}
