using System;

namespace if_else_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintTypeOfNumber();
        }
        static void PrintTypeOfNumber()
        {
            int number = int.Parse(Console.ReadLine());
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive");
            }
            else if(number<0)
            {
                Console.WriteLine($"The number {number} is negative");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero");
            }

        }
    }
}
