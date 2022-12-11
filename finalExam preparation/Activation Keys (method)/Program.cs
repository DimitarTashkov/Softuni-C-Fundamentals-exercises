using System;
using System.Text;

namespace Activation_Keys__method_
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder activationKey = new StringBuilder(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                ProcessCommand(activationKey, command);
            }
            Console.WriteLine($"Your activation key is: {activationKey}");

        }
        static void ProcessCommand(StringBuilder activationKey, string command)
        {
            string[] commands = command
                    .Split(">>>");
            string commandType = commands[0];
            if (commandType == "Contains")
            {
                string substring = commands[1];
                CheckKeyContainsSubstringAndPrintResult(activationKey, substring);

            }
            else if (commandType == "Flip")
            {
                string flipType = commands[1];
                int startIndex = int.Parse(commands[2]);
                int endIndex = int.Parse(commands[3]);//exclusive

                FlipPartOfKeyToUpperOrLower(activationKey, flipType, startIndex, endIndex);

            }
            else if (commandType == "Slice")
            {
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);//exclusive
                SlicePartOfKey(activationKey, startIndex, endIndex);
            }
        }
        static void CheckKeyContainsSubstringAndPrintResult(StringBuilder activationKey,string substring)
        {
            if (activationKey.ToString().Contains(substring))
            {
                Console.WriteLine($"{activationKey} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
        static void FlipPartOfKeyToUpperOrLower(StringBuilder activationKey, string flipType,int startIndex, int endIndex)
        {
            string substring = activationKey.ToString().Substring(startIndex, endIndex - startIndex);

            if (flipType == "Upper")
            {
                substring = substring.ToUpper();
            }
            else if (flipType == "Lower")
            {
                substring = substring.ToLower();
            }

            activationKey.Remove(startIndex, endIndex - startIndex);
            activationKey.Insert(startIndex, substring);

            Console.WriteLine(activationKey);
        }
        static void SlicePartOfKey(StringBuilder activationKey, int startIndex, int endIndex)
        {
            activationKey.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(activationKey);
        }
    }
}
