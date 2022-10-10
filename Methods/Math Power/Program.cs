using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = PoweredNumber(number, power);
            Console.WriteLine(result);
        }

        private static double PoweredNumber(double number, int power)
        {
            double result = number;           
            for (int i = power - 1; i > 0; i--)
            {
                result *= number;
            }
            return result;
        }
    }
}
