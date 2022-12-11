using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesInfo =
                new Dictionary<string, List<string>>();

            string command;
            while((command = Console.ReadLine())!= "end")
            {
                string[] cmdArg = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArg[0];
                string name = cmdArg[1];
                if(!coursesInfo.ContainsKey(courseName))
                {
                    //NEVER FORGET TO INSTANTIATE OR YOU WILL RECEIVE EXCEPTION!!!
                    coursesInfo[courseName] = new List<string>();
                }
                //here we are sure that we already have created instance for the value
                coursesInfo[courseName].Add(name);
            }
            foreach(var kvp in coursesInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach(string studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
