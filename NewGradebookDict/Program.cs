using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewGradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.WriteLine("grade: ");
                    double newGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, newGrade);
                }
            }
            while (newStudent != "");

            // Print class roster

            StringBuilder myRoster = new StringBuilder();

            myRoster.Append("\nClass roster:");

            foreach (KeyValuePair<string, double> student in students)
            {
                myRoster.Append(student.Key + " (" + student.Value.ToString() + ")\n");
            }

            Console.Write(myRoster);

            /*Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, double> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);
            */

            Console.ReadLine();
        }
    }
}
