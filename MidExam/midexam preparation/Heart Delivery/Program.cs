using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> neighborhoods = Console.ReadLine()
                 .Split("@")
                 .Select(byte.Parse)
                 .ToList();

            string command;
            int cupidPosition = 0;
            int lastPositionIndex = 0;
            int countOfPlaces = 0;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(commands[1]);
                                   
               cupidPosition += index;
               if (cupidPosition > neighborhoods.Count-1)
               {
                  cupidPosition = 0;
               }
               if(neighborhoods[cupidPosition] == 0)
               {
                  Console.WriteLine($"Place {cupidPosition} already had Valentine's day.");
               }
               else
               {
                  neighborhoods[cupidPosition] -= 2;
                  lastPositionIndex = cupidPosition;
                  if (neighborhoods[cupidPosition] == 0)
                  {
                      Console.WriteLine($"Place {cupidPosition} has Valentine's day.");

                  }                     
               }                                                                        
             
            }
            Console.WriteLine($"Cupid's last position was {lastPositionIndex}.");
            for (int i = 0; i < neighborhoods.Count; i++)
            {
                if(neighborhoods[i] == 0)
                {
                    countOfPlaces++;
                }
            }
            if (countOfPlaces == neighborhoods.Count)//if(neightborhoads.Sum == 0)
            {
                Console.WriteLine("Mission was successful.");
                
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhoods.Count-countOfPlaces} places.");
            }
        }
    }
}
