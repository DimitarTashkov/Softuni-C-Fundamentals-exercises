using System;
using System.Linq;

namespace Encrypt__Sort__and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            string currentSum = "";

            int currentNum = 0;

            int[] encrypted = new int[n];

            int swapPlaces;

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();                    
                for (int j = 0; j < names.Length; j++)
                {
                    currentSum = names[j]+"";
                    currentNum = names[j];
                    if (currentSum == "a"||currentSum == "o" || currentSum == "e" || currentSum == "i" || currentSum == "u" || currentSum == "y"||
                        currentSum == "A" || currentSum == "O" || currentSum == "E" || currentSum == "I" || currentSum == "U" || currentSum == "Y" )
                    {
                        currentNum *= names.Length;
                    }
                    else
                    {
                        currentNum /= names.Length;
                    }
                    sum += currentNum;
                    encrypted[i] = sum;
                    
                    
                }
                sum = 0;
            }
            for (int i = 0; i < encrypted.Length-1; i++)
            {
                for (int j = 0; j < encrypted.Length-1; j++)
                {
                    if(encrypted[j] > encrypted[j+1])
                    {
                        swapPlaces = encrypted[j + 1];
                        encrypted[j + 1] = encrypted[j];
                        encrypted[j] = swapPlaces;
                    }

                }

            }
            Console.WriteLine("");
            foreach(int chislo in encrypted)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}
