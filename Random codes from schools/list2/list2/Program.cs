using System;
using System.Collections.Generic;
using System.Linq;

namespace list2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            for (int i = 0; i< nums.Count;i++)
            {
                Console.WriteLine("nums[{0}] = {1}", i,nums[i]);
            }
        }
    }
}
