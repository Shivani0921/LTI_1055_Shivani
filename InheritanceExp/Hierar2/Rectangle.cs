using System;
using System.Collections.Generic;
using System.Text;

namespace Hierar2
{
    internal class Rectangle:Shape
    {
        public int length { get; set; }
        public int breadth { get; set; }

        public Rectangle(int l, int b, string color, int sides = 2) : base(sides, color)
        {
            length = l;
            breadth = b;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (length * breadth));
        }
    }
}
