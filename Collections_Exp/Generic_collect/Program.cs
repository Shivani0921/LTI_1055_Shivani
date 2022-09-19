using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Generic_collect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //syntax  List<T> nameoflist=new List<>();
            //List<string> fruits = new List<string>();
            //fruits.Add("Grapes");
            //fruits.Add("Apple");
            //fruits.Add("Mango");
            //fruits.Add("Orange");
            //fruits.Add("Banana");
            //Console.WriteLine("unsorted fruits :");

            //foreach (string f in fruits)
            //{
            //    Console.WriteLine(f);
            //}
            //    fruits.Sort();
            //    Console.WriteLine("sorted fruits:");
            //    foreach (string f in fruits)
            //    {
            //        Console.WriteLine(f);                
            //    }

            //syntax of stack class
            //Stack<Student> stack = new Stack<Student>();
            Dictionary<String, String> numbers = new Dictionary<String, string>();
            numbers.Add("andhra", "amaravathi");
            numbers.Add("tamil nadu", "chennai");
            numbers.Add("Karnataka", "banglore");
            Console.WriteLine(numbers["andhra"]);
            Console.WriteLine(numbers.Count);
            foreach (var kvp in numbers)
            {
                Console.WriteLine("key is     " + kvp.Key + "     value is     " + kvp.Value);
            }
            Console.WriteLine("karnataka is present:" + numbers.ContainsKey("karnataka"));
            Console.WriteLine("amaravathi is present:" + numbers.ContainsValue("amaravathi"));
        }
    }
}
