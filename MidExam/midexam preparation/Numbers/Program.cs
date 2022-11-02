using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(long.Parse)
                 .ToList();
            List<long> collectResult = new List<long>();
            bool numbersBiggerThanAverage = false;
            if(numbers.Count >= 1 && numbers.Count <= 10000)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > numbers.Average())
                    {
                        numbersBiggerThanAverage = true;
                        collectResult.Add(numbers[i]);

                    }
                }
                if (numbersBiggerThanAverage)
                {
                    if (numbers.Average() < 0)
                    {
                        Console.WriteLine(string.Join(" ", collectResult));
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", collectResult.OrderByDescending(x => x).Where(x => x > numbers.Average()).Take(5).ToArray()));
                    }

                }
                else
                {
                    Console.WriteLine("No");
                }

            }
           
        }
    }
}
