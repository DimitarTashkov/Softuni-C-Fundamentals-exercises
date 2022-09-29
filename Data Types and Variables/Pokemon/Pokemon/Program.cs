using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactory = byte.Parse(Console.ReadLine());
            double originalValue = pokemonPower*0.50;
            int targetsPoked = 0;
            while(pokemonPower>=distance)
            {
                if (originalValue == pokemonPower)
                {
                    if (exhaustionFactory > 0)
                    {
                        pokemonPower /= exhaustionFactory;
                    }
                }
                if (pokemonPower<distance)
                {
                    break;
                }              
                pokemonPower -= distance;
                targetsPoked++;
            }
            Console.WriteLine(pokemonPower);
            Console.WriteLine(targetsPoked);
        }
    }
}
