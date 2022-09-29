using System;

namespace Left_to_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string numbers = Console.ReadLine();
                char delimiter = ' ';
                string[] splitted = numbers.Split(delimiter);

                long leftNum = long.Parse(splitted[0]);
                long rightNum = long.Parse(splitted[1]);

                long biggerNum = rightNum;
                if(leftNum>rightNum)
                {
                    biggerNum = leftNum;
                }
                

                long sumOfDigits = 0;
                while(biggerNum!=0)
                {
                    sumOfDigits += biggerNum % 10;
                    biggerNum /= 10;
                }
                Console.WriteLine(Math.Abs(sumOfDigits));
            }
        }
    }
}
