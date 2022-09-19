using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchichalinher
{
    internal class Rectangle:Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
    }

    public Rectangle(int l, int b, string color, int sides=2) :base(sides,color)
    {
        Length = l;
        Breadth = b;
    }
    public override void Area()
    {

        Console.WriteLine("Area of Rectangle = " + (Length * Breadth));
    }

}
