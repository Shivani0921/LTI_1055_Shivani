using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_on_InMemory_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> mystudents = new List<Student>()
            {
                new Student(){Id = 1, Name = "Shivani", Gender = "Female", Branch = "Civil" },
                new Student() { Id = 2, Name = "Pranali", Gender = "Female", Branch = "IT" },

            };
            //var result = from stud in mystudents
            //             where stud.Name == "Shivani"
            //             select stud;

            //foreach(Student s in result)
            //    Console.WriteLine(s.Name + " " + s.Id);

            //Console.WriteLine("number of students from civil branch"+result.Count());

            //var S= from s in Student.GetStudents()
            //           where s.Id<105
            //           select s;
            //Console.WriteLine("Number of female students:"+S.Count());


            //foreach(var stud in S)
            //{
            //   Console.WriteLine("Female Student:"+stud.Name);
            //}

            //var R1 = Student.GetStudents().Where(s => s.Id < 1005);



            //foreach (Student stud in R1)
            //{
            //    Console.WriteLine(stud.Name + " " + stud.Id);
            //}
            int N = Student.GetStudents().FindIndex(s => s.Name == "Pranali");
            Console.WriteLine("Position of Pranali in the List is " + N);



            List<Student> studlist = Student.GetStudents();
            studlist.RemoveAt(N);
            foreach (Student st in studlist)
                Console.WriteLine(st.Name);
        }
    }
}
