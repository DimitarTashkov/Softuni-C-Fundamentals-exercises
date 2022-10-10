using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MatrixOfN(n);
        }
        static int MatrixOfN(int n)
        {
            int copyOfI = 0;
            for (int i = 0; i < n; i++)
            {             
                for (int j = n; j > copyOfI; j--)
                {
                    Console.Write(n+" ");
                }
                
                Console.WriteLine(" ");
            }
            return n;
        }
    }
}
