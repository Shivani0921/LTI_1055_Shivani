using System;

namespace ConsoleApp_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            //how to create object of date class?
            //name of object is d1
            //date d1 = new date();
            ////to assign value to fields we call set functions
            //d1.SetDay(2);
            //d1.SetMonth(9);
            //d1.SetYear(2022);
            //Console.WriteLine(d1.GetDay()+ "/"+ d1.Month() + "/" +d1.Year());
            Date birthdate = new Date(21, 6, 2000);
            Console.WriteLine(birthdate);
            Employee e1 = new Employee();
            Console.WriteLine(e1);
            Employee[] emparray = new Employee[3];
            emparray[0] = new Employee(3, "vamsi", "kumar", dept.it, 45000.34f, date);
            emparray[1] = new Employee(4, "cheri", "kolandi", dept.it, 60000.34f, date);
            emparray[2] = new Employee(5, "Giri", "babu", dept.it, 500.34f, date);

       
            Employee.ShowCount();
            Employee.ShowGrossSalary(e2);

            Employee e2 = new Employee(2, "Bill", "Clinton", 70000, new Date(23, 7, 2022), Department.Electrical);
            Console.WriteLine(e2);
        }
    }
}
