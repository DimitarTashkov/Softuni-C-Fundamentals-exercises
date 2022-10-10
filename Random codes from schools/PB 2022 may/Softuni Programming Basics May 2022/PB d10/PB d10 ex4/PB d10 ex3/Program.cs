using System;

namespace PB_d10_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicnumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int n1 = start; n1 <= end; n1++)
            {
                for (int n2 = start; n2 <= end; n2++)
                {
                    counter++;
                    int currsum = n1 + n2;
                    if (currsum == magicnumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({n1} + {n2} = {magicnumber})");
                        return;
                    }

                }

            }
            Console.WriteLine($"{counter} combinations - neither equals {magicnumber}");
        }
    }
}
