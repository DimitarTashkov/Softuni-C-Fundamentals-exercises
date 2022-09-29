using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char currentch = char.Parse(Console.ReadLine());
                    sum += (int)currentch;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
