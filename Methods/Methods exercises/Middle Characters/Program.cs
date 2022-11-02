using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string result = MiddleChar(word);
            Console.WriteLine(result);
        }
        static string MiddleChar(string word)
        {
            string middleChars = "";
            int wordCount = 0;
            for (int i = 0; i < Math.Ceiling((double)word.Length/2); i++)
            {
                wordCount++;
                if (wordCount == Math.Ceiling((double)word.Length/2))
                {
                    middleChars += word[i];
                    
                }
                         
                if (IsEvenOrNo(word) == true && wordCount == Math.Ceiling((double)word.Length / 2))
                {
                    middleChars += word[i+1];
                    break;
                    
                }
            }
            return middleChars;
            
        }
        static bool IsEvenOrNo(string word)
        {
            if(word.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
