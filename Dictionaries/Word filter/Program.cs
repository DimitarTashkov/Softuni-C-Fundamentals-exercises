﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Word_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
                
        }
    }
}
