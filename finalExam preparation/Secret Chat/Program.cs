using System;
using System.Linq;
using System.Text;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while(command != "Reveal")
            {
                string[] commandsInfo = command.Split(":|:",StringSplitOptions.RemoveEmptyEntries);
                string commandName = commandsInfo[0];

                if(commandName == "InsertSpace")
                {
                    int index = int.Parse(commandsInfo[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);

                }
                else if(commandName == "Reverse")
                {
                    string subString = commandsInfo[1];
                    int startIndex = message.IndexOf(subString);

                    if(startIndex != -1)
                    {
                        message = message.Remove(startIndex, subString.Length);
                        message += string.Join("",subString.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "ChangeAll")
                {
                    string substring = commandsInfo[1];
                    string replacement = commandsInfo[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
