using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder encryptedMessage = new StringBuilder(Console.ReadLine());

            string command;
            while((command = Console.ReadLine())!= "Decode")
            {
                string[] commands = command.Split("|");
                string commandType = commands[0];
                if(commandType == "Move")
                {
                    int index = int.Parse(commands[1]);
                    string collect = "";                   
                    for (int i = 0; i < index; i++)
                    {
                        collect += encryptedMessage[i];
                    }
                    encryptedMessage = encryptedMessage.Remove(0, index);
                    encryptedMessage = encryptedMessage.Append(collect);
                }
                else if (commandType == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string value = commands[2];
                   encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (commandType == "ChangeAll")
                {
                    string substring = commands[1];
                    string replacement = commands[2];
                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");


        }
    }
}
