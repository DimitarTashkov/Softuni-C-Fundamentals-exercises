using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArguments = Console.ReadLine().Split(" ");
                string firstName = cmdArguments[0];
                string secondName = cmdArguments[1];
                double grade = double.Parse(cmdArguments[2]);

                Students currentStudent = new Students(firstName, secondName, grade);
                students.Add(currentStudent);
            }
            List<Students> orderedStudents = students.OrderByDescending(s => s.Grade).ToList();
            foreach(Students student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }
        }
    }
    public class Students
    {
        public Students(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; private set; }

        public string SecondName { get; private set; }

        public double Grade { get; private set; }
    }

}
