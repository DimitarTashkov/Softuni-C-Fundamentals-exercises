using System;

namespace swap_array_test_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                 numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length/2; i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
