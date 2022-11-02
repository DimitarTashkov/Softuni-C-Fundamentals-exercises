using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split().
                ToList();

            string input = string.Empty;
            int counter = 0;
            bool end = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
 
                int startIndex = int.Parse(command[0]);
                int endIndex = int.Parse(command[1]);
                bool sameIndex = startIndex == endIndex;
          

                if (startIndex < 0 || startIndex >= list.Count || sameIndex)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    counter++;
                    string added = "-" + counter + "a";
                    list.Insert(list.Count / 2, added);
                    list.Insert(list.Count / 2, added);

                }
                else if (endIndex < 0 || endIndex >= list.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    counter++;
                    string added = "-" + counter + "a";
                    list.Insert(list.Count / 2, added);
                    list.Insert(list.Count / 2, added);

                }

                else
                {
                    counter++;
                    if (list[startIndex] == list[endIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {list[startIndex]}!");
                        string target1 = list[startIndex];
                        string target2 = list[endIndex];

                        int targetIndex1 = list.FindIndex(x => x == target1);
                        list.RemoveAt(targetIndex1);

                        int targetIndex2 = list.FindIndex(x => x == target2);
                        list.RemoveAt(targetIndex2);

                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

                if (list.Count == 0 || list.Count == 1)
                {
                    end = true;
                    Console.WriteLine($"You have won in {counter} turns!");
                    break;
                }
            }

            if (end == false)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}
