using System;
using System.Linq;

namespace slivane_na_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
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


            int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int u = 0; u < arr1.Length - 1; u++)
            {
                for (int v = 0; v < arr1.Length - 1; v++)
                {
                    if (arr1[v] > arr1[v + 1])
                    {
                        int SwapInt1 = arr1[v];
                        arr1[v] = arr1[v + 1];
                        arr1[v + 1] = SwapInt1;
                    }
                }
            }
            for (int z = 0; z < arr.Length; z++)
            {
                Console.WriteLine(arr1[z]);
            }


            for (int b = 0; b < arr.Length; b++)
            {
                for (int c = 0; c < arr.Length; c++)
                {
                    Console.Write(arr[b] + arr[c]);
                }

            }

        }

    }
}


