using System;

namespace Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataTypes = Console.ReadLine();
            int integer;
            double floating;
            char character;
            bool booleant;
            while(dataTypes!="END")
            {
                if(int.TryParse(dataTypes,out integer))
                {
                    Console.WriteLine($"{dataTypes} is integer type");
                }
                else if (double.TryParse(dataTypes, out floating))
                {
                    Console.WriteLine($"{dataTypes} is floating point type");
                }
                else if (char.TryParse(dataTypes, out character))
                {
                    Console.WriteLine($"{dataTypes} is character type");
                }
                else if (bool.TryParse(dataTypes, out booleant))
                {
                    Console.WriteLine($"{dataTypes} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{dataTypes} is string type");
                }
                dataTypes = Console.ReadLine();

            }
        }
    }
}
