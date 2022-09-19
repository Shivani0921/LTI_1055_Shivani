using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    //student is inherited from person class so we can say student is a person
    internal class Student : Person
    {
        int rollno;
        int marks;
        int std;
        public static int count; //default value= 0

        public Student():base()
        {
            rollno = 1;
            marks = 35;
            std = 5;
            count++;
            Console.WriteLine("Student constructor executed");
        }
        public Student(int roll, int m, int s, string name, string address, string contact):base(name, address, contact)
        {
            this.rollno = roll;
            this.marks = m;
            this.std = s;
            count++;
        }
        public static void ShowCount()
        {
            Console.WriteLine("Count of students is " + count);
        }
    }

}
