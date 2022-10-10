using System;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(10,100);
            PrintNumbers(a: 50);
            PrintNumbers(b: 30);
            PrintNumbers();
        }
        static void PrintNumbers(int a = -1,int b = -1 )
        {
            Console.WriteLine($"{a} - {b}");
        }
    }
}
