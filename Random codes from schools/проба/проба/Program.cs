using System;

namespace проба
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var r = 1; r<=n;r++)
            {
                Console.Write("");
                for (var c = 1; c<=n;c++)
                {
                    Console.Write(" *" );
                }
                Console.WriteLine();
            }
        }
    }
}
