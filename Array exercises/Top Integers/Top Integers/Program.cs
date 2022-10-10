using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                bool isTopInteger = true;         
                //pass through all numbers to its right
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    if(nextNum>=currentNumber)
                    {
                        isTopInteger = false;
                        break;
                    }

                }
                if(isTopInteger)
                {
                    Console.Write(currentNumber+" ");
                }
            }
        }
    }
}
