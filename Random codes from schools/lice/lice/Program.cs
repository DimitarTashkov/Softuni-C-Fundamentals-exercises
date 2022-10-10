using System;

namespace lice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете страната на правоъгълника");
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: a = 3;b = 4.21; Console.WriteLine(Math.Round(a * b));break;
                case 2: a = 0.30; b = 4.21; Console.WriteLine(Math.Round(a * b,2)); break;
            }
        }
    }
}
