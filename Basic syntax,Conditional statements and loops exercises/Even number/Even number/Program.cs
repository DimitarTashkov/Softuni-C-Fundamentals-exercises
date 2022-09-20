using System;

namespace Even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int evenNumber = 0;
            
            while(true)
            {
                 number = int.Parse(Console.ReadLine());
                if (number %2 ==0)
                {
                    evenNumber += number;
                    break;
                }
                Console.WriteLine("Please write an even number.");
            }
            if(evenNumber>0)
            {
                Console.WriteLine($"The number is: {evenNumber}");
            }
            else
            {
                Console.WriteLine("The number is: "+evenNumber*-1);
            }
            
        }
    }
}
