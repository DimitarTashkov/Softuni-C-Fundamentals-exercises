using System;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversedWord = "";
            for(int i = word.Length-1;i>=0;i--)
            {
                char reversed = word[i];
                reversedWord += reversed;
            }
            Console.WriteLine(reversedWord);
        }
    }
}
