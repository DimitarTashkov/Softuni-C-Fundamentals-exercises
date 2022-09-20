using System;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            if(first>second && first>third)
            {
                if(second>third)
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(first);
                    Console.WriteLine(third);
                    Console.WriteLine(second);
                }
                
            }
            if (second > first && second > third)
            {
                if (first > third)
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(second);
                    Console.WriteLine(third);
                    Console.WriteLine(first);
                }

            }
            if (third > first && third > second)
            {
                if (first > second)
                {
                    Console.WriteLine(third);
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(third);
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                }

            }
            
        }
    }
}
