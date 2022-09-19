using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExmp
{
    internal class Student: IPrintable
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Marks { get; set; }
        public int ResultMonth { get; set; }

        public void Print()
        {
            if (Marks >= 50)
            {
                Console.WriteLine("Id:" + Id + "Name:" + Name + "Result = Pass");
            }
            else
            {
                Console.WriteLine("Id:" + Id + "Name:" + Name + "Result = Fail");
            }
        }

        public void ShowDate()
        {
            Console.WriteLine("The result is declared in the month"+DateTime.Now.Month );
        }
    }
}

