using System;
using System.Linq;
using System.Collections.Generic;

namespace Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            string command;
            while((command = Console.ReadLine())!= "end")
            {
                List<string> commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string commandType = commands[0];
                if(commandType == "Chat")
                {
                    string message = commands[1];
                    chat.Add(message);
                }
                else if(commandType == "Delete")
                {
                    string message = commands[1];
                    if(chat.Contains(message))
                    {
                        chat.Remove(message);
                    }
                }
                else if (commandType == "Edit")
                {
                    string message = commands[1];
                    string editedMessage = commands[2];
                    if(!chat.Contains(message))
                    {
                        continue;
                    }
                    chat.Insert(chat.IndexOf(message), editedMessage);
                    chat.Remove(message);
                }
                else if(commandType == "Pin")
                {
                    string message = commands[1];
                    if(chat.Contains(message))
                    {
                        chat.Add(message);
                        chat.Remove(message);
                    }
                }
                else if(commandType == "Spam")
                {
                    for (int i = commands.IndexOf(commands[1]); i < commands.Count; i++)
                    {
                        chat.Add(commands[i]);
                    }
                }
            }
            for (int i = 0; i < chat.Count; i++)
            {
                Console.WriteLine(chat[i]);
            }
        }
    }
}
