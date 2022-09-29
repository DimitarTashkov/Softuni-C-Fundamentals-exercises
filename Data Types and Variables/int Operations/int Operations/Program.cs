using System;
using System.Numerics;

namespace int_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            long firstResult = (long)first + second;
            long division = firstResult / third;
            BigInteger multiply = (BigInteger)division * fourth;
            Console.WriteLine($"{multiply}");
            

        }
    }
}
