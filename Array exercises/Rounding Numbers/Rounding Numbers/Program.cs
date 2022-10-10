using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] chisla = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            for (int i = 0; i < chisla.Length; i++)
            {
                Console.WriteLine($"{chisla[i]} => {(int)Math.Round(chisla[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
