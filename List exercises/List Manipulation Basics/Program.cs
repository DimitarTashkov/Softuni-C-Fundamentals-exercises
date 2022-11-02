using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while(input != "end")
            {
                string[] inputParameter = input.Split();
                string command = inputParameter[0];
                if(command == "Add")
                {
                    int value = int.Parse(inputParameter[1]);
                    numbers.Add(value);

                }
                else if(command == "Remove")
                {
                    int value = int.Parse(inputParameter[1]);
                    numbers.Remove(value);

                }
                else if(command == "RemoveAt")
                {
                    int value = int.Parse(inputParameter[1]);
                    numbers.RemoveAt(value);

                }
                else if(command == "Insert")
                {
                    int value = int.Parse(inputParameter[1]);
                    int index = int.Parse(inputParameter[2]);
                    numbers.Insert(index, value);

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
