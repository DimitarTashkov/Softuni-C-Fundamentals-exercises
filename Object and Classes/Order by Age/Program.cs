using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Details> people = new List<Details>();
            while((command = Console.ReadLine())!= "End")
            {
                string[] commands = command.Split(" ");
                string name = commands[0];
                string id = commands[1];
                int age = int.Parse(commands[2]);               
                Details detail = new Details(name, id, age);
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Id == id)
                    {
                        people[i].Name = name;
                        people[i].Age = age;
                    }
                    continue;
                }
                people.Add(detail);
            }
            foreach(Details person in people
                .OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
    class Details
    {
        public Details(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }


    }
}
