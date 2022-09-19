using System;

namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Shivani K";
            //string str1 = "Hello " + name + ", How are you?";
            //string str1 = string.Format("Hello {0}, How are you?", name);
            //string str1 = $"Hello {name}, How are you?";


            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Substring(0, 4));
            Console.WriteLine(name.Substring(5));
            Console.WriteLine(name.Replace("K", "Kayasth"));
            Console.ReadKey();
            //Console.WriteLine(str1);
        }
    }
}
