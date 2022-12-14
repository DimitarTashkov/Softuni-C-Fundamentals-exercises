using System;
using System.Linq;
using System.Collections.Generic;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstCollection = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> secondCollection = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int n = Math.Min(firstCollection.Count, secondCollection.Count);
            for (int i = 0; i < n; i++)
            {
                result.Add(firstCollection[i]);
                result.Add(secondCollection[i]);
            }
            if(firstCollection.Count > secondCollection.Count)
            {
                for (int i = n; i < firstCollection.Count; i++)
                {
                    result.Add(firstCollection[i]);
                }

            }
            else if(secondCollection.Count>firstCollection.Count)
            {
                for (int i = n; i < secondCollection.Count; i++)
                {
                    result.Add(secondCollection[i]);
                }
            }
            Console.Write(string.Join(" ", result));
        }
    }
}
