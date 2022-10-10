using System;

namespace PB_d5_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numone = int.Parse(Console.ReadLine());
            int numtwo = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            string resultprint = "";
            double result = 0;
            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (result % 2 == 0)
                {
                    resultprint += " - even";
                }
                else
                {
                    resultprint += " - odd";
                }
                Console.WriteLine(resultprint);
                if (operation == '+')
                {
                    result = numone + numtwo;
                }
                else if (operation == '-')
                {
                    result = numone - numtwo;
                }
                else
                {
                    result = numone * numtwo;
                }
            }
            else if (operation == '/'|| operation== '%')
            {
            if(numtwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numone} by zero");
                }
            else
                {
                    if(operation == '/')
                    {
                        result = numone / numtwo;
                    }
                    else
                    {
                        result = numone % numtwo;
                    }
                     resultprint = $"{numone} {operation} {numtwo} = {result}";
                }
            }
        }
    }
}
