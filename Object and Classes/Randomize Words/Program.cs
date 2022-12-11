using System;
using System.Linq;
using System.Collections.Generic;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            //Welcome to SoftUni and have fun learning programming
            for (int i = 0; i < input.Length; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, input.Length);
                string currentWord = input[i];
                string nextWord = input[randomIndex];
                input[i] = nextWord;
                input[randomIndex] = currentWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
