using System;
using System.Collections.Generic;
using System.Text;

namespace Multilevelinhert
{
    internal class Point
    {
        //auto implemented properties
        public int X { get; set; }
        public int Y{ get; set; }

        public Point()
        {
            X = 10;
            Y = 20;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            
        }
    }
}
