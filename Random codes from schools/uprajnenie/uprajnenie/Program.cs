using System;
using System.Linq;

namespace uprajnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some words:");
            string[] dumi = Console.ReadLine().Split(" ").ToArray();
            Console.WriteLine("1=Reverse,2=Distinct,3=Replace");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("You choosed to reverse the array");
                Array.Reverse(dumi);
                foreach (string duma in dumi)
                {
                    Console.WriteLine("Reversed text:" + duma);
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("You choosed to distinct the array");
                string[] remove = dumi.Distinct().ToArray();
                foreach (string duma in remove)
                {
                    Console.WriteLine("Distincted text:" + duma);
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("You choosed to replace the array");
                Console.WriteLine("Now you should choose which statement to be replaced");
                string textzasmqna = Console.ReadLine();
                Console.WriteLine("Choose the text you want ot use to change it ");
                string textskoitodagosmenish = Console.ReadLine();
                for (int i = 0; i < dumi.Length; i++)
                {
                    if (dumi[i] == textzasmqna)
                    {
                        dumi[i] = textskoitodagosmenish;
                        foreach (string duma in dumi)
                        {
                            string.Join(" ", duma);
                        }
                    }
                   
                }

            }

        }
    }
}
