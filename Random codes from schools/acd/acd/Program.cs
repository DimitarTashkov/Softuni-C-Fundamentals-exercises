using System;
using System.Linq;
using System.Collections.Generic;

namespace acd
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                List<int> lists = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                List<int> result = new List<int>();
            for (int index1 = lists.Count - 1; index1 >= 0; index1--)
            {
                for (int index2 = 0; index2 < nums.Count; index2++)
                {
                    if (nums[index2] != null)
                    {
                        result.Add(nums[index2]);
                        Console.WriteLine("{0}", result[index2]);
                    }
                }
            }
        }
    }
}

