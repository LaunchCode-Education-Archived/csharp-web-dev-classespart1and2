using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        private int level; //100-899, i.e. MATH 323
        public string Name { get; set; }
        public int NumberOfCredits { get; set; }
        //public string Program { get; set; } 
        //public string Degree { get; set; } 
        //public string Major { get; set; }
        //public string Semester { get; set; }
        //public string Professor { get; set; }

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
