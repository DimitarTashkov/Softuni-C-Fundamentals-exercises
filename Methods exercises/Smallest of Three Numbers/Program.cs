using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = MinValue(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }
        static int MinValue(int firstNumber, int secondNumber, int thirdNumber)
        {
            int result = 0;
            if(firstNumber<secondNumber && firstNumber<thirdNumber)
            {
                result = firstNumber;
            }
            else if (secondNumber<firstNumber && secondNumber<thirdNumber)
            {
                result = secondNumber;
            }
            else 
            {
                result = thirdNumber;
            }
            return result;
        }
    }
}
