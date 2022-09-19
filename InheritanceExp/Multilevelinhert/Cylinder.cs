
using System;
using System.Collections.Generic;
using System.Text;

namespace Multilevelinhert
{
    internal class Cylinder:Circle
    {
        public int Height { get; set; }
        public Cylinder()
        {
            Height = 100;
        }
        public Cylinder(int r, int h, int x,int y):base(r,x,y)
        {
            Height = h;
        }

    }
}
