using System;
using System.Linq;
using System.Collections.Generic;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string input;
            while((input = Console.ReadLine())!= "end")
            {
                string[] cmdArgument = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgument[0];
                if(command == "Delete")
                {
                    int number = int.Parse(cmdArgument[1]);
                    while(numbers.Contains(number))
                    {
                        numbers.Remove(number);
                    }
                }
                else if(command == "Insert")
                {
                    int element = int.Parse(cmdArgument[1]);
                    int position = int.Parse(cmdArgument[2]);
                    numbers.Insert(position,element);
                }

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
