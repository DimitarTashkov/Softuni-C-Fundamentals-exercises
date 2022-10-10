using System;

namespace Chasovnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("minutite sa:");
            var minuti = int.Parse(Console.ReadLine());
            Console.WriteLine("chas");
            var chas = int.Parse(Console.ReadLine());
            if (chas >= 0 && chas <= 24)
            {
                if (minuti >= 0 && minuti <= 60)
                    Console.WriteLine("Chasa e veren");
                else
                {
                    Console.WriteLine("Chasa e greshen");
                }
            }
            
        }
    }
}
