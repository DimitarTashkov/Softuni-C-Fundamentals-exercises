﻿using System;
using System.Numerics;

namespace Big_Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factoriel = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
