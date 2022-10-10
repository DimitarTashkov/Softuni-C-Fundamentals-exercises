using System;
using System.Linq;
namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            int rotationCounts = int.Parse(Console.ReadLine());

            int timesToRotate = rotationCounts % numbers.Length;
            for (int r = 1; r <= timesToRotate; r++)
            {
                int firstElement = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i - 1] = numbers[i];
                }
                numbers[numbers.Length - 1] = firstElement; 

            }
            Console.WriteLine(String.Join(" ",numbers));

        }
    }
}
