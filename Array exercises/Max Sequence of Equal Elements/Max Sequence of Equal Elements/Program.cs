using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int longestSequanceLength = 1;
            int longestSequanceStart = 0;
            int currentSequanceLength = 1;
            int currentSequanceStart = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] == numbers[i-1])
                {
                    currentSequanceLength++;
                    if(currentSequanceLength>longestSequanceLength)
                    {
                        longestSequanceLength = currentSequanceLength;
                        longestSequanceStart = currentSequanceStart;
                    }
                }
                else
                {
                    currentSequanceLength = 1;
                    currentSequanceStart = i;
                }    
            }
            for (int i = longestSequanceStart; i < longestSequanceLength+ longestSequanceStart; i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }
    }
}
