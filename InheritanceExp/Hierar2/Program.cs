using System;
using System.Drawing;

namespace Hierar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(12, 5, "red");
            rec.Area();
            Triangle tri = new Triangle(7, 5, "pink");
            tri.Area();
        }
    }
}
