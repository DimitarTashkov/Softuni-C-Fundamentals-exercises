using System;

namespace idk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 17;
            numbers[4] = 4;
            for (int i = 0;i<numbers.Length;i++)
            {
                Console.Write(numbers[i]+" " );
            }
        }
    }
}
