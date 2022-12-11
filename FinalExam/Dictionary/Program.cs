using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> myDictionary =
                new Dictionary<string, List<string>>();
            List<string> collectTeacherWords = new List<string>();
            string[] wordsAndDefintions = Console.ReadLine()
                .Split(" | ");
            foreach (string word in wordsAndDefintions)
            {
                string[] splitWordsAndDefinitions = word.Split(": ");
                if(myDictionary.ContainsKey(splitWordsAndDefinitions[0]))
                {
                    myDictionary[splitWordsAndDefinitions[0]].Add(splitWordsAndDefinitions[1]);
                    continue;
                }
                myDictionary[splitWordsAndDefinitions[0]] = new List<string>();
                myDictionary[splitWordsAndDefinitions[0]].Add(splitWordsAndDefinitions[1]);
            }
            string[] teacherWords = Console.ReadLine().Split(" | ");
            
            foreach (string teacherWord in teacherWords)
            {
                collectTeacherWords.Add(teacherWord);
            }
            string command = Console.ReadLine();
            if (command == "Test")
            {
                for (int i = 0; i < collectTeacherWords.Count; i++)
                {
                    string word = collectTeacherWords[i];
                    if(myDictionary.ContainsKey(word))
                    {
                        Console.WriteLine(word+":");
                        foreach (string definition in myDictionary[word])
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                foreach (var item in myDictionary)
                {
                    Console.Write(item.Key+" ");
                }
            }
        }
    }
}
