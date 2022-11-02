using System;
using System.Linq;
using System.Collections.Generic;
namespace List_Manipulation_Advanced
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
            bool isChecked = false;
            while (input != "end")
            {
                string[] inputParameter = input.Split();
                string command = inputParameter[0];
                if (command == "Add")
                {
                    int value = int.Parse(inputParameter[1]);
                    numbers.Add(value);
                    isChecked = true;

                }
                else if (command == "Remove")
                {
                    int value = int.Parse(inputParameter[1]);
                    numbers.Remove(value);
                    isChecked = true;

                }
                else if (command == "RemoveAt")
                {
                    int value = int.Parse(inputParameter[1]);
                    numbers.RemoveAt(value);
                    isChecked = true;

                }
                else if (command == "Insert")
                {
                    int value = int.Parse(inputParameter[1]);
                    int index = int.Parse(inputParameter[2]);
                    numbers.Insert(index, value);
                    isChecked = true;

                }
                else if (command == "Contains")
                {
                    int value = int.Parse(inputParameter[1]);
                    if(numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    

                }
                else if(command == "PrintEven")
                {
                    Console.WriteLine(
                        string.Join(" ",numbers.Where(x => x % 2 == 0)));
                    
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(
                        string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if(command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if(command == "Filter")
                {
                    string condition = inputParameter[1];
                    int value = int.Parse(inputParameter[2]);

                    if(condition == "<")
                    {
                        Console.WriteLine(
                            string.Join(" ",numbers.Where(x => x<value)));

                    }
                    else if(condition == "<=")
                    {
                        Console.WriteLine(
                            string.Join(" ", numbers.Where(x => x <= value)));

                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(
                            string.Join(" ", numbers.Where(x => x > value)));

                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(
                            string.Join(" ", numbers.Where(x => x >= value)));

                    }
                }

                input = Console.ReadLine();
            }
            if(isChecked)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
