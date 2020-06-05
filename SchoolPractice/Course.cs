using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        private int level; //100-899, i.e. MATH 323
        private List<Student> Roster;
        public string Name { get; set; }
        public int NumberOfCredits { get; set; }

        public Course(int level, string name, int numberOfCredits)
        {
            this.level = level;
            Name = name;
            NumberOfCredits = numberOfCredits;
        }

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                if (value > 899 || value < 100 || value % 1 != 0)
                {
                    throw new ArgumentException("Invalid course number");
                }

                level = value; 
            }
        }

    }
}
