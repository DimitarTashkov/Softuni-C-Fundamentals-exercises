using System;

namespace For_cycles_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1, 100," ");
            Console.WriteLine(" ");
            PrintNumbers(3, 33,"!");
            Console.WriteLine(" ");
            PrintNumbers(5, 25,"*");
        }
        static void PrintNumbers(int start, int end,string delimeter)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+delimeter);
            }
        }
    }
}
