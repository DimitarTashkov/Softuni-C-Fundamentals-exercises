using System;

namespace Spice_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int starting = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int spices = 0;
            int max = 0;
            while(starting>=100)
            {
                spices = starting - 26;
                 max += spices;
                starting -= 10;
                daysCount++;
                if (starting<100)
                {
                    max -= 26;
                    break;
                }


            }
            Console.WriteLine(daysCount);
            Console.WriteLine(max);
        }
    }
}
