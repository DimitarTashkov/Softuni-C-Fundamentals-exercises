using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte tank = 255;
            int n = int.Parse(Console.ReadLine());
            short max = 0;
            for (int i = 1; i <= n; i++)
            {
                short liters = short.Parse(Console.ReadLine());               
                if (max+liters>tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    max += liters;
                }

            }
            Console.WriteLine(max);
        }
    }
}
