using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int number = startNumber;
            int everyDigit = 0;
            int totalSum = 0;
            while(number>0)
            {
                int factoriel = 1;
                everyDigit = number % 10;
                number /= 10;
                for(int i = 1;i<=everyDigit;i++)
                {
                    factoriel *= i;
                }
                totalSum+=factoriel;
            }
            if(startNumber == totalSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        
    }
}
