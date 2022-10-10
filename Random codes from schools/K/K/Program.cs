using System;

namespace K
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            switch (y)
            {
                case 1: k = 1; Console.WriteLine("y="+6.7);break;
                case 2: k = 2; Console.WriteLine("y="+Math.Round(6.7 +9 * k)); break;
                case 3: k = 3; Console.WriteLine("y="+Math.Round(6.7 + 9 * k + 7 * k * k)); break;
            }
        }
    }
}
