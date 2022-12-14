using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if(numbers[i] % 2 == 0)
                {
                    sum += currentNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
