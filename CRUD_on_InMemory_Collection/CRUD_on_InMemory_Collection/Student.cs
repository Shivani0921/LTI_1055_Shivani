using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_on_InMemory_Collection
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
        public string Branch { get; set; }

        public static List<Student>GetStudents()
        {
            List<Student> students = new List<Student>();
            {
                new Student() { Id = 101, Name = "Shivani", Gender = "Female", Branch = "Civil" };
                new Student() { Id = 102, Name = "Pranali", Gender = "Female", Branch = "IT" };
                new Student() { Id = 103, Name = "Bob", Gender = "Male", Branch = "Mechanical" };

                new Student() { Id = 104, Name = "Avni", Gender = "Female", Branch = "CS" };
                new Student() { Id = 105, Name = "Ashok", Gender = "Female", Branch = "Electrical" };
                new Student() { Id = 106, Name = "Mounika", Gender = "Female", Branch = "Instrumental" };
            };
            return students;


        }
    }
}
