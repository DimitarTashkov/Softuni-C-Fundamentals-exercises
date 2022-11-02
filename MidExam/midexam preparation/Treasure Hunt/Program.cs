using System;
using System.Linq;
using System.Collections.Generic;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine()
                 .Split("|",StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            List<string> collectRemovedElements = new List<string>();
            string command;
            while((command = Console.ReadLine())!= "Yohoho!")
            {
                List<string> commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string commandType = commands[0];
                if(commandType == "Loot")
                {
                    for (int i = commands.IndexOf(commands[1]); i < commands.Count; i++)
                    {
                        if(!initialLoot.Contains(commands[i]))
                        {
                            initialLoot.Insert(initialLoot.IndexOf(initialLoot[0]),commands[i]);
 
                        }
                    }

                }
                else if(commandType == "Drop")
                {
                    short index = short.Parse(commands[1]);
                    if(index >= -200 && index<=initialLoot.Count && index <=200)
                    {
                        if(index<0)
                        {
                            continue;
                        }
                        initialLoot.Add(initialLoot[index]);
                        initialLoot.Remove(initialLoot[index]);
                    }
                }
                else if(commandType == "Steal")
                {
                    byte countforSteal = byte.Parse(commands[1]);
                    while (countforSteal>0)
                    {
                        collectRemovedElements.Add(initialLoot[initialLoot.Count - countforSteal]);
                        initialLoot.Remove(initialLoot[initialLoot.Count-countforSteal]);
                        countforSteal--;
                    }
                    Console.Write(string.Join(", ",collectRemovedElements));
                    Console.WriteLine(" ");
                   
                }

            }
            double sum = 0;
            double avg = 0;
            foreach(string word in initialLoot)
            {                
                 sum += word.Length;
            }
            avg = sum / initialLoot.Count;
            if(initialLoot.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
                
            }
            else
            {
                Console.WriteLine($"Average treasure gain: {avg:f2} pirate credits.");
            }
        }
    }
}
