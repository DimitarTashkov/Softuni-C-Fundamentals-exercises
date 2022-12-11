using System;
using System.Linq;
using System.Collections.Generic;

namespace Odd_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            Dictionary<string, int> counts =
                new Dictionary<string, int>();
            foreach(string word in words)
            {
                string lowerCasedWord = word.ToLower();
                if(counts.ContainsKey(lowerCasedWord))
                {
                    counts[lowerCasedWord]++;
                }
                else
                {
                    counts.Add(lowerCasedWord, 1);
                }
            }
            foreach(var count in counts)
            {
                if(count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
