using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());
            string input;
            while((input = Console.ReadLine())!= "end")
            {
                string[] cmdArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstArgument = cmdArguments[0];
                if(firstArgument == "Add")
                {
                    int secondArgument = int.Parse(cmdArguments[1]);
                    wagons.Add(secondArgument);
                }
                else
                {
                    int addPassengers = int.Parse(cmdArguments[0]);
                    if(wagons[0] + addPassengers <=maxWagonCapacity)
                    {
                        wagons[0] += addPassengers;
                    }
                    else
                    {
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            
                            if(wagons[i] + addPassengers <= maxWagonCapacity)
                            {
                                wagons[i] += addPassengers;
                                break;
                            }
                        }
                       
                    }
                }
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
