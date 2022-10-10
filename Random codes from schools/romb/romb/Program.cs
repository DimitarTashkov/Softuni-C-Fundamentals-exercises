using System;

namespace romb
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var row = 1; row<=n;row++)
            {
              for (var col = 1; col<=n-row;col++)
                {
                    Console.Write("");
                }
                Console.Write("*");
                for (var col = 1; col < row; col++)
                {
                    Console.Write(" *");            
                }
                Console.WriteLine();
            }
        }
    }
}
