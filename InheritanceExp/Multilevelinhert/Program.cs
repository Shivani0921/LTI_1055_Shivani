using System;

namespace Multilevelinhert
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Point P = new Point();
           P.X = 10;
           //P.Y = 5; because it is read only as set method is removed from point class
           Console.WriteLine("Cordinates of point are" + P.X + " " + P.Y);

            Circle C1 = new Circle(7, 10, 12);
            Console.WriteLine("Circle details are:" + C1.Radius + "Cordinates of center point" + C1.X + C1.Y);


            Cylinder cy1 = new Cylinder(7, 120, 2, 2);
            Console.WriteLine("Cylinder details are Radius:" + cy1.Radius + "Height: " + cy1.Height + "Coordinates:" + cy1.X + cy1.Y);
            Console.WriteLine("Cylinder details");
        }
    }
}
