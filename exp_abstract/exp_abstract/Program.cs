using System;

namespace exp_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car C1 = new Car("Maruti","Desire","red", 30 );
            C1.showSpeed();
            // Vehicle V1 = new Vehicle(); abstract class instance cannot be created
            C1.showColor();
        }
    }
}
