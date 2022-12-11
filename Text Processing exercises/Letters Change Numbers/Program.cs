using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach(string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1]; //same as item.Length-1 
                string numAsString = item[1..^1]; // this will give us everything that
                                                  // is between 0 and the last index
                double numberFromString = double.Parse(numAsString);
                if(char.IsUpper(firstLetter))
                {
                    int positionOfTheLetter = firstLetter-64;
                    numberFromString /= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numberFromString *= positionOfTheLetter; 
                }

                if(char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numberFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numberFromString += positionOfTheLetter;
                }
                sum += numberFromString;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
