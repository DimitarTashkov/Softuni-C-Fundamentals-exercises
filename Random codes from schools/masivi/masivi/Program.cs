using System;
using System.Linq;

namespace masivi
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int chislo = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int SwapInt = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = SwapInt;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                
            }
        }

    }
}

