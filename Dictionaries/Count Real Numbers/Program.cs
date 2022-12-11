using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numberOcr = new SortedDictionary<double, int>();
            double[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            foreach (var currentNumber in inputNumbers)
            {
                if(!numberOcr.ContainsKey(currentNumber))
                {
                    numberOcr.Add(currentNumber, 0);
                }
                numberOcr[currentNumber] += 1;

            }
            foreach (var item in numberOcr)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
