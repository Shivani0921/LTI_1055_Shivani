using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExmp
{
    internal class Car : IPrintable
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Seats { get; set; }
        public int ManufactureYear { get; set; }
        public void Print()
        {
            Console.WriteLine("Brand: " + Brand + "Model: " + Model + " Seats " + Seats);
        }

        public void ShowDate()
        {
            int Y= DateTime.Now.Year;
            Console.WriteLine("Manufacturing Year:"+Y);
        }
    }
}
