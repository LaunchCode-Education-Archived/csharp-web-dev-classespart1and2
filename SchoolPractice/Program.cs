using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student leslie = new Student("Leslie", 1, 1, 4.0);
            Console.WriteLine(leslie.Name + " is a student.");
        }
    }
}
