using System;
using System.Linq;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split("").ToArray();
            for (int i = 0;i<nums.Length/2;i++)
            {
                SwapElements(nums, i, nums.Length - 1 - i);
                Console.WriteLine(string.Join("", nums));
            }
        }
        static void SwapElements(string[]arr, int i, int j)
        {
            var Oldelement = arr[i];
            arr[i] = arr[j];
            arr[j] = Oldelement;
        }
    }
}
