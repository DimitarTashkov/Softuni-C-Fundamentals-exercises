using System;
using System.Text;

namespace Activation_keys
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder activationKey = new StringBuilder(Console.ReadLine());
            string command;
            while((command = Console.ReadLine())!= "Generate")
            {
                string[] commands = command
                    .Split(">>>");
                string commandType = commands[0];
                if(commandType == "Contains")
                {
                    string substring = commands[1];
                    if(activationKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }  
                else if (commandType == "Flip")
                {
                    string flipType = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);//exclusive

                    string substring = activationKey.ToString().Substring(startIndex, endIndex-startIndex);

                    if(flipType == "Upper")
                    {
                        substring = substring.ToUpper();
                    }
                    else if (flipType == "Lower")
                    {
                        substring = substring.ToLower();
                    }

                    activationKey.Remove(startIndex, endIndex-startIndex);
                    activationKey.Insert(startIndex, substring);
                    Console.WriteLine(activationKey);
                }
                else if (commandType == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);//exclusive
                    activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");

        }
    }
}
