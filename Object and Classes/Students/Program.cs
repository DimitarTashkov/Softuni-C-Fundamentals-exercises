using System;
using System.Linq;
using System.Collections.Generic;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Students> students = new List<Students>();
            while(input != "end")
            {
                string[] personInfo = input.Split();

                string firstName = personInfo[0];
                string secondName = personInfo[1];
                int age = int.Parse(personInfo[2]);
                string town = personInfo[3];

                Students student = new Students(firstName, secondName, age, town);

                input = Console.ReadLine();
                students.Add(student);
            }
            string desiredTown = Console.ReadLine();
            foreach(Students currentStudent in students)
            {
                if(currentStudent.Town == desiredTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.SecondName} is {currentStudent.Age} years old.");
                }
            }
        }
    }
   public class Students
    {
        public Students(string firstName, string secondName, int age,string town)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }
    }
}
