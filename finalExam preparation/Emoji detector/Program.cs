using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Emoji_detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            BigInteger coolThreshold = CalculateCoolThreshold(inputText);

            string pattern = @"((\:\:)|(\*\*))(?<emoji>[A-Z][a-z]{2,})(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (Match match in matches)
            {
                string emojiWord = match.Groups["emoji"].Value;
                long emojiCoolness = CalculateEmojiCoolness(emojiWord);

                if(emojiCoolness >= coolThreshold)
                {
                    Console.WriteLine($"{match.Value} ");
                }
            }

        }
        static BigInteger CalculateCoolThreshold(string inputText)
        {
            BigInteger coolThreshold = 1;
            foreach (char character in inputText)
            {
                if (char.IsDigit(character))
                {
                    int digit = (int)character - 48;
                    coolThreshold *= digit;
                }
            }
            return coolThreshold;
        }
        static long CalculateEmojiCoolness(string emojiWord)
        {
            long emojiCoolness = 0;
            foreach (char ch in emojiWord)
            {
                emojiCoolness += (int)ch;
            }
            return emojiCoolness;
        }
    }
}
