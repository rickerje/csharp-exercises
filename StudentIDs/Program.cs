using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentIDs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("Name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.WriteLine("Student Number: ");
                    int newStuNum = int.Parse(Console.ReadLine());

                    students.Add(newStudent, newStuNum);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            Console.ReadLine();
        }
    }
}
