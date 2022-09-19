using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = { 12, 79, 24, 75, 26, 17, 18};
            
            //var ans= from variable in datasource select variable
            var result=from p in numbers
                       where p%5==0
                       orderby p
                       select p;

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            List <string> cities=new List<string>();
            cities.Add("Pune");
            cities.Add("Mumbai");
            cities.Add("Nagpur");
            cities.Add("Bangalore");
            cities.Add("Delhi");
            cities.Add("Amravati");

            var cts = from c in cities
                      where c[0] =='M'
                      //orderby c
                      select c;
                     
            foreach(string ct in cts)
            {
                Console.WriteLine(ct);
            }

            //lambda expression
            var R = cities.Any(c=>c.Contains("re")); //like OR condition
            Console.WriteLine("is there any city name which contains re?"+R);
            Console.WriteLine("Cities count is="+cities.Count());

            var N = cities.All(c => c.Contains("A")); //like AND condition
            Console.WriteLine("is there any city name which contains A?" + R);

            float[] temperature = { 23, 34, 45, 34.6f, 79.08f };
            var ans1 = temperature.Sum();
            Console.WriteLine("Sum of all temperature="+ans1);

            var ans2 = temperature.Count();
            Console.WriteLine("count of elements=" + ans2);

            Console.WriteLine("Average Temperature is:"+temperature.Average());
            Console.WriteLine("Maximum Temperature is:" + temperature.Max());
            Console.WriteLine("Minimum Temperature is:" + temperature.Min());



        }
    }
}
