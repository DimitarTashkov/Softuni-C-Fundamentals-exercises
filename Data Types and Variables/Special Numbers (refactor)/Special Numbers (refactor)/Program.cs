using System;

namespace Special_Numbers__refactor_
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolkko = int.Parse(Console.ReadLine());
            
            int duplicateOfN = 0;
            bool isSpecialNumbers = false;
            for (int n = 1; n <= kolkko; n++)
            {
                int sum = 0;
                duplicateOfN = n;
                while (duplicateOfN > 0)
                {
                    sum += duplicateOfN % 10;
                    duplicateOfN /= 10;
                    
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecialNumbers = true;
                    Console.WriteLine("{0} -> {1}", n, isSpecialNumbers);
                    isSpecialNumbers = false;
                }
                else
                {
          
                    Console.WriteLine("{0} -> {1}",n,isSpecialNumbers);
                }

            }

        }
    }
}
