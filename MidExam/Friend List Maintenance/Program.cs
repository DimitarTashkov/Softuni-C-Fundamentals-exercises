using System;
using System.Linq;
using System.Collections.Generic;

namespace Friend_List_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                 .Split(", ")
                 .ToList();
            string command;
            int blackListedNamesCount = 0;
            int lostNamesCount = 0;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commands[0];
                if (commandType == "Blacklist")
                {
                    string blackListedName = commands[1];
                    string blacklisted = "Blacklisted";
                    if (names.Contains(commands[1]))
                    {
                        Console.WriteLine($"{commands[1]} was blacklisted.");
                        names.Insert(names.IndexOf(commands[1]), blacklisted);
                        names.Remove(commands[1]);
                        blackListedNamesCount++;
                    }
                    else if (!names.Contains(commands[1]))
                    {
                        Console.WriteLine($"{commands[1]} was not found.");
                    }
                }
                else if (commandType == "Error")
                {
                    int index = int.Parse(commands[1]);
                    if (index < 0 || index >= names.Count)
                    {
                        continue;
                    }
                    if (names[index] != "Blacklisted" && names[index] != "Lost")
                    {
                        string lost = "Lost";
                        Console.WriteLine($"{names[index]} was lost due to an error.");
                        names.Insert(names.IndexOf(names[index]), lost);
                        names.Remove(names[index + 1]);
                        lostNamesCount++;
                    }
                    else if (names[index] == "Blacklisted" || names[index] == "Lost")
                    {
                        continue;
                    }
                }
                else if (commandType == "Change")
                {
                    int index = int.Parse(commands[1]);
                    string change = commands[2];
                    if (index >= 0 && index < names.Count)
                    {
                        Console.WriteLine($"{names[index]} changed his username to {commands[2]}.");
                        names.Insert(names.IndexOf(names[index]), commands[2]);
                        names.Remove(names[index + 1]);

                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {blackListedNamesCount}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
