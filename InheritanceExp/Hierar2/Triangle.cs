using System;
using System.Collections.Generic;
using System.Text;

namespace Hierar2
{
    internal class Triangle:Shape
    {
        public int base1 { get; set; }
        public int height { get; set; }

        public Triangle(int ba, int h, string color, int sides = 2) : base(sides, color)
        {
            base1 = ba;
            height = h;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Triangle: " + (0.5 * base1 * height));
        }
    }
}
