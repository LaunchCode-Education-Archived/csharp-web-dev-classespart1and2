using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        private List<Student> Roster;
        public string Name { get; set; }
        public int NumberOfCredits { get; set; }

        public Course(string name, int numberOfCredits)
        {

            Name = name;
            NumberOfCredits = numberOfCredits;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ")";
        }
    }
}
