using System;
using System.Collections.Generic;
using System.Text;

namespace exp_abstract
{
    internal class Vehicle
    {
        public int color{ get; set; }

        public int speed { get; set; }

        public Vehicle()
        {
            this.color = color;
            this.speed = speed;
        }

        abstract public void showSpeed();

        public void showColor()
        {
            Console.WriteLine("the color of the {0} is:"+color);
        }

        
    }
}
