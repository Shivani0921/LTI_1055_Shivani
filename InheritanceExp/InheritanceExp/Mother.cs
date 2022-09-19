using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExp
{
    internal class Mother
    {
        string Mname;
        int Mage;

        public Mother()
        {
            Mname = "Kiruthika";
            Mage = 45;
        }

        public Mother(string name, int age)
        {
            Mname = name;
            Mage = age;
        }
        public override string ToString()
        {
            return "Mother_Details" + Mname + "" + Mage;
        }
    }
}
