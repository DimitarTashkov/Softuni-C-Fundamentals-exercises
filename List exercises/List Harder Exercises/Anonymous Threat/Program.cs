using System;
using System.Linq;
using System.Collections.Generic;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> result = new List<string>();
            if(words.Contains(" "))
            {
                words.Remove(" ");
            }
            string command;
            while((command = Console.ReadLine())!= "3:1")
            {
                string[] commands = command
                    .Split(' ')
                    .ToArray();
                string commandType = commands[0];
                if(commandType == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    FixInvalidIndexes(words,ref startIndex, ref endIndex);
                    MergeWords(words, startIndex, endIndex);                   
                    
                }
                else if(commandType == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);

                    string word = words[index];                    
                    List<string> particionList = DivideWord(word,partitions);
                    
                    words.RemoveAt(index);
                    words.InsertRange(index, particionList);
                    
                }
            }
            Console.WriteLine(string.Join(" ",words));
        }
        static void FixInvalidIndexes(List<string> words,ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                //First possible
                startIndex = 0;
            }

            if(startIndex>= words.Count)
            {
                startIndex = words.Count - 1;
            }
            if(endIndex <= 0)
            {
                endIndex = 0;
            }

            if (endIndex >= words.Count)
            {
                //Last possible
                endIndex = words.Count - 1;
            }

        }
        static void MergeWords(List<string> words, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currentWord = words[startIndex];
                mergedText += currentWord;
                words.RemoveAt(startIndex);

            }
            words.Insert(startIndex, mergedText);

        }
        static List<string> DivideWord(string word, int partitions)
        {
            int substringsLength = word.Length / partitions;
            int lastSubstringLength = word.Length - ((partitions - 1) * substringsLength);

            List<string> particionList = new List<string>();
            //All without the last
            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = substringsLength;
                if (i == partitions - 1)
                {
                    desiredLength = lastSubstringLength;
                }
                char[] newPartitionArr = word.
                    Skip(i * substringsLength).
                    Take(desiredLength).
                    ToArray();
                string newPartition = string.Join("", newPartitionArr);
                particionList.Add(newPartition);
            }
            return particionList;


        }

    }
}
