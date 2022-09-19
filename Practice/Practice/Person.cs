using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Person
    {

        string name;
        string address;
        string contact;

        public Person()
        {
            name = "person name";
            address = "Local address";
            contact = "000000";
            Console.WriteLine("Person Constructor executed");

        }
        public Person(string name, string address, string contact)
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
        }

    }
}
