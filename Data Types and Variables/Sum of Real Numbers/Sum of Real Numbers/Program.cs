﻿using System;

namespace Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal inputNumber = decimal.Parse(Console.ReadLine());
                sum += inputNumber;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
