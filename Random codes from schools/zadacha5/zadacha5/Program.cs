using System;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n: ");
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                if (num % (3 * 7) != 0)
                {
                   Console.WriteLine(num);
                }
            }
        }
    }
}
