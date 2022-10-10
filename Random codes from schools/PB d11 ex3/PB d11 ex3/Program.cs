using System;

namespace PB_d11_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            int primeSum = 0;
            int compoundSum = 0;
            while(word != "stop")
            {
                word = Console.ReadLine(); //'6'
               if(word == "stop")
               {
                    break;
               }
                int numbers = int.Parse(word);//6

                if(numbers < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                bool numberIsPrime = true;
              for(int divider = 2;divider < numbers; divider++)
              {
                int remainder = numbers % divider;
                    if(remainder == 0)
                    {
                        compoundSum += numbers;
                        numberIsPrime = false;
                        break;
                    }
              }
             
              if(numberIsPrime)
              {
                    primeSum += numbers;
              }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {compoundSum}");
        }
    }
}
