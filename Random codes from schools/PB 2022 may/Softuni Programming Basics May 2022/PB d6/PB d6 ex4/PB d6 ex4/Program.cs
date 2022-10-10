using System;

namespace PB_d6_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0;i<=n;i+=2)
            {
                Console.WriteLine(i*i);
            }
        }
    }
}
