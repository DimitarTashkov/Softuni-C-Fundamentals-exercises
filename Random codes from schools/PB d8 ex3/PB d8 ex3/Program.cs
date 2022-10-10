using System;

namespace PB_d8_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int wanted = int.Parse(Console.ReadLine());
            int sum = 0;
            while(sum<wanted)
                {
                int currentnumber = int.Parse(Console.ReadLine());
                sum += currentnumber;
                }
            Console.WriteLine(sum);
        }
    }
}
