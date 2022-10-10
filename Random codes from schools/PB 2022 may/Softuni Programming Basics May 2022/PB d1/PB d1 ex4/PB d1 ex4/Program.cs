using System;

namespace PB_d1_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int hpages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine(pages / hpages / days);
        }
    }
}

