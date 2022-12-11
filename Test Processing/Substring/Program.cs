using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string speacialWord = Console.ReadLine();
            string text = Console.ReadLine();
            while(text.Contains(speacialWord))
            {
                int startIndex = text.IndexOf(speacialWord);
                text = text.Remove(startIndex,speacialWord.Length);
            }
            Console.WriteLine(text);
        }
    }
}
