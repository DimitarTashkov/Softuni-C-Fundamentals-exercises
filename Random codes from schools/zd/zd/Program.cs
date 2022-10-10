using System;

namespace zd
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = 0;
            double S = a * b;
            double P = 2 * (a + b);
            double diagonal = Math.Sqrt(c = a + b);
            Console.WriteLine("S = {0},Perimeter = {1}, diagonal = {2} ", S, P, diagonal);
        }
    }
}
