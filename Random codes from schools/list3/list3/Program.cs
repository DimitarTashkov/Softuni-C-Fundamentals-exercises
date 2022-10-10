using System;
using System.Collections.Generic;
using System.Linq;

namespace list3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter names:");
            List<string> imena = Console.ReadLine().Split(',').ToList();   
            for(int i = 0;i<imena.Count;i++)
            {
                Console.WriteLine(String.Join(',',imena[i+1]));
            }
        }
    }
}
