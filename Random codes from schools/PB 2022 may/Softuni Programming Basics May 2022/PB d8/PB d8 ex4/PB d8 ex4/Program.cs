using System;

namespace PB_d8_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = 1;
            while(k<=number)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
