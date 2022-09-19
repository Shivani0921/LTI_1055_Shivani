using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Class
{
    internal class Date
    {
        private int day, month, year;

        public Date()
        {
            day = 15;
            month = 9;
            year = 2022;
        }
        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }
        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
    }
}
