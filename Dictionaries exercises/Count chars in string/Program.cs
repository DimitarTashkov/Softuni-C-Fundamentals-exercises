using System;
using System.Collections.Generic;

namespace Count_chars_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> occurance = 
                new Dictionary<char, int>();
            string text = Console.ReadLine();
            foreach(char ch in text)
            {
                if(ch != ' ')
                {
                    if (!occurance.ContainsKey(ch))
                    {
                        occurance[ch] = 0;
                    }
                    occurance[ch]++;
                }
            }
            foreach(var kvp in occurance)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
