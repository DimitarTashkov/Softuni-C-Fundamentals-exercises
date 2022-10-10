using System;

namespace PB_d2_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if(grade>=5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
