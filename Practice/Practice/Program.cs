using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student s = new Student();
           Student s1 = new Student(123,67,5, "shivani", "pune","98787564");
           Student s2 = new Student(145,45,3,"bob","nagpur", "862324");
           Student s3 = new Student(156, 46, 3, "emilly", "delhi", "86223724");

           Console.WriteLine("Total count of students",+Student.count);
           Student.ShowCount();
        }
    }
}
