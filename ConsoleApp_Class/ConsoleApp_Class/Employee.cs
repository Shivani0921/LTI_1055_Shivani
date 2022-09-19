using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Class
{
    enum Department { IT, Accounts, Civil, Sales, HR, Electrical}
    internal class Employee
    {
        int empid;
        string firstname;
        string lastname;
        decimal salary;
        Date doj; //containment means obj of one class is present in another class
        Department dept;
        static int count;
        static Employee()
        {
            Console.WriteLine("This is a static constructor...");
            count = 100;
        }

        public Employee()
        {
            empid = 1;
            firstname = "Shivani";
            lastname = "Kayasth";
            salary = 60000;
            doj = new Date(1, 1, 1987);
            dept = Department.IT;
            count++;
            Console.WriteLine("This is a default constructor");
        }
        public Employee(int id, string firstname, string lastname, decimal salary, Date d, Department dept)
        {
            empid = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.salary = salary;
            doj = d;
            this.dept = dept;
            Console.WriteLine("This is parameterised constructor...");
            count++;
        }
        public override string ToString()
        {
            return "Employee Details are : " + empid + " Name :" + firstname + " " + lastname + "\n Salary :" + salary +
                "\n" + doj.ToString() +"\n";
        }
        public static void ShowCount()
        {
            Console.WriteLine("Total number of employees"+count);
        }
        public static void ShowGrossSalary(Employee emp)
        {
            decimal gross = emp.salary + emp.salary * 0.70m + 500;
            Console.WriteLine("Gross Salary = " + gross);
        }
    }
}
