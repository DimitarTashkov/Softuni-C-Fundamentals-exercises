using System;
using System.Collections.Generic;
using System.Linq;

namespace list4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imena = Console.ReadLine().Split(',').ToList();
            for (int i = 0;i<imena.Count-1;i++)
            {
                Console.WriteLine("Hora2 = {0}", imena[i]);
            }
        }
    }
}
