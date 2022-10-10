using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayname = Console.ReadLine();
            var monthday = int.Parse(Console.ReadLine());
            var date = int.Parse(Console.ReadLine());
            Console.WriteLine("Днес е {0}, {1}, {2}.", dayname, monthday, date);

        }
    }
}
