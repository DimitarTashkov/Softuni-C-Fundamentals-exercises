using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3; 
            int b = 2;
            int c = 4;
            bool d;
            d = (a < b && 3 < 0); 
            Console.WriteLine("Отговора е:" + d);
            bool g;
            g= a < b || 3 < 0;
            Console.WriteLine("Отговора е:" + g);

        }
    }
}
