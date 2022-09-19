using System;
using System.Collections.Generic;
using System.Text;

namespace Multilevelinhert
{
    internal class Circle:Point
    {
        public int Radius { get; set; }

        public Circle()
        {
            Radius = 10;
        }
        public Circle(int r, int x, int y):base(x,y)
        {
            Radius = r;
        }
    }
}
