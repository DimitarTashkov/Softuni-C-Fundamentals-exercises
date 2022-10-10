using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumbers = int.Parse(Console.ReadLine());
            double result = GetResult(firstNumber, @operator, secondNumbers);
            Console.WriteLine(result);
        }

        private static double GetResult(int firstNumber, string @operator, int secondNumbers)
        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = firstNumber + secondNumbers;
                    break;
                case "-":
                    result = firstNumber - secondNumbers;
                    break;
                case "*":
                    result = firstNumber * secondNumbers;
                    break;
                case "/":
                    result = firstNumber / secondNumbers;
                    break;
            }
            return result;

        }
    }
}
