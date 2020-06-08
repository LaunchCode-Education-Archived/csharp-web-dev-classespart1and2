using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            float totalQualityScore = (float)Gpa * NumberOfCredits;
            totalQualityScore += (float)grade * courseCredits;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if (NumberOfCredits <= 59 && NumberOfCredits >= 30)
            {
                return "Sophmore";
            }
            else if (NumberOfCredits <= 89 && NumberOfCredits >= 60)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.studentId == studentId;
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
    }

}
