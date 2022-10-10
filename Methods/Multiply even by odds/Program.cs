using System;

namespace Multiply_even_by_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int absValue = Math.Abs(int.Parse(input));
            int sumOfEvenDigit = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOddDigits = GetSumOfOddDigits(absValue.ToString());
            int result = sumOfEvenDigit * sumOfOddDigits;
            Console.WriteLine(result);
        }

        private static int GetSumOfOddDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {

                //1.Tostring = "1"
                int currentNumber = int.Parse(input[i].ToString());
                if (currentNumber % 2 != 0)
                {
                    sum += currentNumber;
                }
            }
            return sum;

        }

        private static int GetSumOfEvenDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                //1.Tostring = "1"
                int currentNumber = int.Parse(input[i].ToString());
                if(currentNumber%2 == 0)
                {
                    sum += currentNumber;
                }
            }
            return sum;
        }
    }
}
