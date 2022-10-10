using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int numberFromSum = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == numberFromSum)
                    {

                        firstNumber = numbers[i];
                        secondNumber = numbers[j];
                        Console.WriteLine($"{firstNumber} {secondNumber}");
                    }
                }
               
            }
        }
    }
}
