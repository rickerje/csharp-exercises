using School;
using System;
using System.Collections.Generic;

namespace School
{

    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        public readonly int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            StudentId = nextStudentId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentID, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double currentQualityScore = this.numberOfCredits * this.Gpa;
            double courseQualityScore = grade * courseCredits;

            this.NumberOfCredits += courseCredits;
            this.Gpa = courseQualityScore + currentQualityScore / this.NumberOfCredits;

            // Update the appropriate properties: NumberOfCredits, Gpa
        }

        public string GetGradeLevel()
        {
            string gradeLevel = "";

            if (this.NumberOfCredits <= 29)
            {
                gradeLevel = "freshman";
            }
            else if (this.NumberOfCredits >= 30 && this.NumberOfCredits <= 59)
            {
                gradeLevel = "sophomore";
            }
            else if (this.NumberOfCredits >= 59 && this.NumberOfCredits <= 89)
            {
                gradeLevel = "junior";
            }
            else
            {
                gradeLevel = "senior";
            }

            return gradeLevel;
        }

        public override bool Equals(Object o)
        {
            Student studentObj = o as Student;
            return Gpa == studentObj.Gpa;
        }

        public override String ToString()
        {
            return Name + " (Student ID: " + StudentID + ", " + GetGradeLevel() + ")";
        }

    }
}
    public class Course
{
    public string courseNum { get; set; }
    public string courseTitle { get; set; }
    public static int classSize { get; set; }
    public List<Student> studentRoster { get; set; };


    public override String ToString()
    {
        string printCourse = courseNum + ": " + courseTitle + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")\n Roster: \n";
        foreach(Student student in studentRoster)
        {
            printCourse += student.ToString();
        }

        return printCourse;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
