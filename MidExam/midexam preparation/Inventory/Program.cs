using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command;
            List<string> inventory = new List<string>(items);
            while((command = Console.ReadLine())!= "Craft!")
            {
                string[] commands = command.Split(" - " );
                string commandType = commands[0];
                string element = commands[1];
                
                if(commandType == "Collect")
                {
                    if(!inventory.Contains((string)element))
                    {
                        inventory.Add(element);
                    }
                    continue;
                }
                else if(commandType == "Drop")
                {
                    if(inventory.Contains(element))
                    {
                        inventory.Remove(element);
                    }
                    continue;
                }
                else if(commandType == "Renew")
                {
                    if(inventory.Contains(element))
                    {
                        inventory.Add(element);
                        inventory.Remove(element);
                    }
                    continue;
                    
                }
                else if(commandType == "Combine Items")
                {
                    string elements = commands[1];
                    string[] splitElements = elements.Split(":");
                    string oldItem = splitElements[0];
                    string newItem = splitElements[1];
                    if(inventory.Contains(oldItem))
                    {
                        inventory.Insert((inventory.IndexOf(oldItem) + 1), newItem);
                    }
                    continue;
                 
                }
            }
            Console.WriteLine(string.Join(", ",inventory));
        }
    }
}
