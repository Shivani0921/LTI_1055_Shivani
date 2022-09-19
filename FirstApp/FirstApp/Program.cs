using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Shivani Kayasth";
            //string str1 = "Hello" + name + ", How are you?"
            //string str1 = string.Format("Hello {0}, How are you?", name);
            string str1 = $"Hello {name} , How are you ?";
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
