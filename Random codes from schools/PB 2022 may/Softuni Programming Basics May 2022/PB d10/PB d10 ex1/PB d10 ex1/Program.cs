using System;

namespace PB_d10_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0;h<=23;h++)
            {
                for(int m = 0; m<=59; m++)
                {
                    Console.WriteLine($"{h:d1}:{m}");
                }
            }
        }
    }
}
