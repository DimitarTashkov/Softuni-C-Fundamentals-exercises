using System;
using System.Linq;
using System.Collections.Generic;


namespace Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plantRatings =
                new Dictionary<string, List<double>>();
            Dictionary<string, int> plantRarities =
                new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = input[0];
                int rarity = int.Parse(input[1]);

                if (!plantRarities.ContainsKey(plantName))
                {
                    plantRarities.Add(plantName, rarity);
                    plantRatings.Add(plantName, new List<double>());
                }
                else
                {
                    plantRarities[plantName] = rarity;
                }


            }
            string command = Console.ReadLine();
            while(command != "Exhibition")
            {
                string[] commands = command.Split(new char[] { ' ', ':', '-' },
                    StringSplitOptions.RemoveEmptyEntries);
                string commandName = commands[0];
                string plantName = commands[1];
                if (commandName == "Rate")
                {
                    double rating = double.Parse(Console.ReadLine());
                    if (plantRatings.ContainsKey(plantName))
                    {
                        plantRatings[plantName].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (commandName == "Update")
                {
                    int rarity = int.Parse(commands[2]);
                    if (plantRarities.ContainsKey(plantName))
                    {
                        plantRarities[plantName] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "Reset")
                {
                    if (plantRatings.ContainsKey(plantName))
                    {
                        plantRatings[plantName].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                command = Console.ReadLine();

            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var (plantName, plantRarity) in plantRarities)
            {
              
                    double average = plantRatings[plantName].Count > 0 
                    ? plantRatings[plantName].Average()
                    : 0;
                    Console.WriteLine($"- {plantName}; Rarity: {plantRarity}; Rating: {average:f2}");
                
                
            }
        }
    }
}
