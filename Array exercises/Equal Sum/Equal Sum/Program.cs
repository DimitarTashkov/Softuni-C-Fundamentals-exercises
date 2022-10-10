using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chisla = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < chisla.Length; i++)
            {
                for (int j = i + 1; j < chisla.Length; j++)
                {
                    sumRight += chisla[j];
                }
                if(sumLeft == sumRight)
                {
                    Console.Write(i);
                    return;
                }
                sumLeft += chisla[i];
            }
            Console.WriteLine("no");
        }
    }
}
