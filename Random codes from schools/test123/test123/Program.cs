using System;

namespace test123
{
    class Program
    {
        static void Main(string[] args)
        {
            int vek = int.Parse(Console.ReadLine());
            int years = vek * 100;
            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;
            long m = minutes;
            Console.WriteLine("Vekove = {0}, godini = {1}, dni = {2}, chasove {3}, minuti {4}", vek, years, days, hours, m);
        }
    }
}
