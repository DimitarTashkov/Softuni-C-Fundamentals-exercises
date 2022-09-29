using System;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;         
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double biggerNumber = a;
            double smallerNumber = b;
            if(b>a)
            {
                biggerNumber = b;
                smallerNumber = a;
            }
            if(biggerNumber-smallerNumber<eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
