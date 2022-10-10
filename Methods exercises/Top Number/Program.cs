using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            IsTopNumber(number);
        }

        private static void IsTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                bool oddDigit = false;
                int copyOfI = i;
                while (true)
                {
                    if (copyOfI == 0)
                    {
                        break;
                    }
                    int eachNumber = copyOfI % 10;
                    sum += eachNumber;
                    if (!(eachNumber % 2 == 0))
                    {
                        oddDigit = true;
                    } 
                    copyOfI /= 10;
                }
                if (sum % 8 == 0 && oddDigit == true)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
