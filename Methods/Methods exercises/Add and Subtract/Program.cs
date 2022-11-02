using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = Substract(firstNumber,secondNumber,thirdNumber);
            Console.WriteLine(result);
        }
        static int Sum(int first, int second,int third)
        {
            int sum = first + second;
            return sum;
        }
        static int Substract(int first,int second,int third)
        {                     
             int sum = third - Sum(first, second,third);          
            return sum*-1;
        }
        
    }
}
