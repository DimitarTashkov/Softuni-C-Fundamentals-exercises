﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Manipulating_lists_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            for (int index = 0; index < nums.Count; index++)
            {
            if(nums[index]< 0)
                {
                    nums.RemoveAt(index);index--;
                    Console.WriteLine(nums[index]);
                }

            }
            
        } 
    }
}
