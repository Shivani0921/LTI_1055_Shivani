using System;

namespace InterfaceExmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car() { Model = "Swift Dezire", Brand = "Maruti", Seats = 7, ManufactureYear = 2022 };
            mycar.Print();
            mycar.ShowDate();
            Student Shivani = new Student() { Id = 1, Name = "Bob", Marks = 30, ResultMonth=0 };
            Shivani.Print();
            Shivani.ShowDate();
        }
    }
}
