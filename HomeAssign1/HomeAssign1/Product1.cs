using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAssign1
{
    enum Category { A, B, C, D, E, F }
    internal class Product1
    {
        int prodid;
        string prodname;
        double price;
        DateTime dom;
        Category Catg;
        public Product1()
        {
            prodid = 1;
            prodname = "Mouse";
            price = 9.50f;
            dom = new DateTime(2022, 9, 2);
            Catg = 0;
        }
        public Product1(int id, string name, double p, DateTime d, Category ca)
        {
            prodid = id;
            prodname = name;
            price = p;
            dom = d;
            Catg = ca;

        }
        public override string ToString()
        {
            return "\n The product details are: \n Product id: " + prodid + "\n" + " Product Name: " + prodname + "\n Price: " + price + "\n Date of Manufacture: " + dom.ToString() + "\n Category: " + Catg;
        }

    }
}
