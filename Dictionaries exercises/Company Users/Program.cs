using System;
using System.Linq;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> compainies =
                new Dictionary<string, List<string>>();
            string command;
            while((command = Console.ReadLine())!= "End")
            {
                string[] commands = command.Split(" -> ");
                string company = commands[0];
                string employee = commands[1];
                if(!compainies.ContainsKey(company))
                {
                    compainies.Add(company, new List<string>());
                }
                if(compainies.ContainsKey(company)&& !compainies[company].Contains(employee))
                {
                    compainies[company].Add(employee);
                }
            }
            foreach(var company in compainies)
            {
                Console.WriteLine(company.Key);
                foreach(var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
