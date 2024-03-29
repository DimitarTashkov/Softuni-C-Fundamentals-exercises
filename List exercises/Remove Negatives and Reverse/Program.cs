﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]<0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            //numbers.RemoveAll(x => x < 0); removes all elements which are less than 0

            numbers.Reverse();

            if(numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.Write(string.Join(" ", numbers));
            }
            
        }
    }
}
