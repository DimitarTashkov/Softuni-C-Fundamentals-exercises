using System;
using System.Linq;
using System.Collections.Generic;

namespace list_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            List<int> nums = new List<int>();
            for (int index = result.Count-1;index>=0;index--)
            {
                result = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                for (int index2 = 0; index2<nums.Count;index2++)
                {
                if(nums[index2]>=0)
                    {

                    }
                }
            }
        }
    }
}
