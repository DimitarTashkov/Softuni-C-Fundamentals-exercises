using System;
using System.Linq;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            seq[0] = 1;
            for (int i =1;i<n;i++)
            {
             for (int k = 0;k<seq.Length;k++)
                {
                    seq[i] = sum(seq[i - k + i - 1]);
                }
            }

        }
    }
}
