using System;

namespace PB_d11_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());
            for(int i = firstnum; i<= secondnum;i++)
            {
                string currentnum = i.ToString();
                int oddsum = 0;
                int evensum = 0;
                for(int j = 0;j<=currentnum.Length; j++)
                {
                    int currentdigit = int.Parse(currentnum[j].ToString());
                    if(j % 2 == 0)
                    {
                        evensum += currentdigit;
                    }
                    else
                    {
                        oddsum += currentdigit;
                    }

                }
                if(oddsum == evensum)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
