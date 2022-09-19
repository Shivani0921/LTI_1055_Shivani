using System;

namespace AssignmentInherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ria", 15000);
            emp.GrossSalary();
            Manager man = new Manager(44, 20000, "Banu", 25555);
            //man.GrossSalary();

            Employee e = man;
            e.GrossSalary();
            man.GrossSalary();
        }
    }
}
