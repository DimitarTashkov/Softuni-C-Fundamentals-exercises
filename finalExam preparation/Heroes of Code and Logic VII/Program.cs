using System;
using System.Collections.Generic;
namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroesWithHp = new Dictionary<string, int>();
            Dictionary<string, int> heroesWithMana = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] heroArguments = Console.ReadLine()
                    .Split(" ");
                string heroName = heroArguments[0];
                int healthPoints = int.Parse(heroArguments[1]);
                int manaPoint = int.Parse(heroArguments[2]);

                heroesWithHp[heroName] = healthPoints;
                heroesWithMana[heroName] = manaPoint;
            }
            string command;
            while ((command = Console.ReadLine())!= "End")
            {
                string[] cmdArg = command.Split(" - ");
                string cmdType = cmdArg[0];
                string heroName = cmdArg[1];

                if (cmdType == "CastSpell")
                {
                    int manaPointsNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];

                    if (heroesWithMana[heroName] >= manaPointsNeeded)
                    {
                        heroesWithMana[heroName] -= manaPointsNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesWithMana[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmdType == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];

                    heroesWithHp[heroName] -= damage;

                    if (heroesWithHp[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesWithHp[heroName]} HP left!");
                    }
                    else
                    {
                        heroesWithHp.Remove(heroName);
                        heroesWithMana.Remove(heroName);

                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (cmdType == "Recharge")
                {
                    int amount = int.Parse(cmdArg[2]);

                    if(heroesWithMana[heroName] + amount > 200)
                    {
                        amount = 200 - heroesWithMana[heroName];//Max recharge
                    }
                    heroesWithMana[heroName] += amount;

                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (cmdType == "Heal")
                {
                    int amount = int.Parse(cmdArg[2]);

                    if (heroesWithHp[heroName] + amount > 100)
                    {
                        amount = 100 - heroesWithHp[heroName];//Max heal
                    }
                    heroesWithHp[heroName] += amount;

                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
            }
            foreach (var kvp in heroesWithMana)
            {
                string heroName = kvp.Key;
                int manaPoints = kvp.Value;
                int healthPoints = heroesWithHp[heroName];

                Console.WriteLine($"{heroName}");
                Console.WriteLine($"  HP: {healthPoints}");
                Console.WriteLine($"  MP: {manaPoints}");
            }
        }
    }
}
