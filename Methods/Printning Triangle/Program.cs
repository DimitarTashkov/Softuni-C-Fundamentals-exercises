using System;

namespace Printning_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            Triangle(numbers);
        }
        static void Triangle(int numbers)
        {
            for (int row = 1; row <= numbers; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }

            for (int row = numbers - 1; row >= 0; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
