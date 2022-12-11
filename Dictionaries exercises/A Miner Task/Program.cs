﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources =
                new Dictionary<string, int>();
            string resource;
            while((resource = Console.ReadLine())!= "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if(!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;
            }
            foreach(var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
