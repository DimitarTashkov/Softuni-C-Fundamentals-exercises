using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while((input = Console.ReadLine())!="END")
            {
                Console.WriteLine(ReadNumbers(input));
            }

            
        }
        static bool ReadNumbers(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
                if (input[i] != input[input.Length - 1 - i]) return false;

            return true;
        }
    }
}
