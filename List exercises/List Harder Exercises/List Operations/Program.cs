using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command;
            while((command = Console.ReadLine())!= "End")
            {
                string[] cmdArguments = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArguments[0];
                if(cmdType == "Add")
                {
                    int numberToAdd = int.Parse(cmdArguments[1]);
                    numbers.Add(numberToAdd);
                }
                else if(cmdType == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArguments[1]);
                    int index = int.Parse(cmdArguments[2]);
                    if(IsIndexInValid(ref numbers,index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, numberToInsert);
                }
                else if(cmdType == "Remove")
                {
                    int removeIndex = int.Parse(cmdArguments[1]);
                    if(IsIndexInValid(ref numbers,removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(removeIndex);
                }
                else if(cmdType == "Shift")
                {
                    string direction = cmdArguments[1];
                    int count = int.Parse(cmdArguments[2]);
                    if(direction == "left")
                    {
                        ShiftListLeft(ref numbers, count);
                    }
                    else
                    {
                        ShiftListRight(numbers, count);
                    }
                }

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        static bool IsIndexInValid(ref List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;

        static void ShiftListLeft(ref List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];//take first number
                numbers.RemoveAt(0);//remove first number
                numbers.Add(firstNumber);//Add adds the number to the end of the list

            }

        }
        static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];//take first number
                numbers.RemoveAt(numbers.Count - 1);//Remove last number
                numbers.Insert(0, lastNumber);
            }
        }

    }
}
