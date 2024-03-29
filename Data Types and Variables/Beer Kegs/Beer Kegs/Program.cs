﻿using System;
using System.Numerics;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = BigInteger.MinusOne;
            string bestModel = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius,2) * height;
                if((BigInteger)volume>maxValue)
                {
                    maxValue = (BigInteger)volume;
                    bestModel = model;

                }
            }
            Console.WriteLine(bestModel);
        }
    }
}
