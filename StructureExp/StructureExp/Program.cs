using System;

namespace StructureExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P = new Point(10, 20);
            Console.WriteLine("x co cordinate:" + P.X);
            Console.WriteLine("y co cordinate:" + P.Y);
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine("Month:"+dt.Month);
            Console.WriteLine("Year:"+dt.Year);
            Console.WriteLine("Day of week:"+dt.DayOfWeek);
            Console.WriteLine("Day of month:"+dt.Day);

        }
    }
        public struct Point

        {

            int x, y;

            public Point(int x, int y)

            {

                this.x = x;

                this.y = y;

            }

            public int X

            {

                get { return x; }

                set { x = value; }

            }

            public int Y

            {

                get { return y; }

                set { y = value; }

            }

        }
}

