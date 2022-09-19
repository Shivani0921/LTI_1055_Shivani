using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAssign2
{
    enum Category { A, B, C, D, E }
    internal class Medi
    {
        int medId;
        string medName;
        string medUse;
        double price;
        DateTime doe;
        Category cat;
        public Medi()
        {
            medId = 10;
            medName = "Paracetamol";
            medUse = "Fever";
            price = 15.50f;
            doe = new DateTime(2022, 9, 2);
            cat = Category.A;
        }
        public Medi(int id, string name, string use, double p, DateTime d, Category Ca)
        {
            medId = id;
            medName = name;
            medUse = use;
            price = p;
            doe = d;
            cat = Ca;
        }
        public override string ToString()
        {
            return "\n The Medicine details are: \n Medicine id: " + medId + "\n Medicine name: " + medName + "\n Medicine Use: " + medUse + "\n Price: " + price + "\n Date of Expiry: " + doe.ToString() + "\n Category: " + cat;
        }
    }
}
