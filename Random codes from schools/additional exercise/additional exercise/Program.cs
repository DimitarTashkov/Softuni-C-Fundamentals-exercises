using System;
using System.Linq;
using System.Collections.Generic;
namespace additional_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> chisla = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> suma = new List<int>();
            int reversedNumbers = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            foreach(int chislo in chisla)
            {
                firstNumber = chislo % 10;
                firstNumber = firstNumber * 10;
                secondNumber = chislo / 10;
                reversedNumbers = firstNumber + secondNumber;
                Console.Write(reversedNumbers+" ");
                suma.Add(reversedNumbers);
            }
            Console.WriteLine("");
            Console.WriteLine($"The sum of the list is: {suma.Sum()}");


        }
    }
}
