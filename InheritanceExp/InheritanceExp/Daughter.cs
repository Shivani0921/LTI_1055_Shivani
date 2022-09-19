using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExp
{
    internal class Daughter:Mother
    {
        string Dname;
        int D_age;

        public Daughter():base()
        {
            Dname = "Shivani";
            D_age = 12;
        }

        public Daughter(string name1, int age1, string name2,  int age2):base(name2,age2)
        {
            Dname=name1;
            D_age=age1;
        }
        public override string  ToString()
        {
            return "Daughter's details" + Dname + " " + D_age + " " + base.ToString();
        }
    }
}
