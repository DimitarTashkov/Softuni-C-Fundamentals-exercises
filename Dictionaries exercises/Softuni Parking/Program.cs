using System;
using System.Linq;
using System.Collections.Generic;

namespace Softuni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register =
                new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ");
                string commandType = commands[0];
                string username = commands[1];
                if(commandType == "register")
                {
                    string licensePlateNumber = commands[2];
                    if(!register.ContainsKey(username))
                    {
                        register[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        string registeredPlateNumber = register[username];
                        Console.WriteLine($"ERROR: already registered with plate number {registeredPlateNumber}");
                    }
                }
                else if (commandType == "unregister")
                {
                    if(!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach(var userLicensePair in register)
            {
                Console.WriteLine($"{userLicensePair.Key} => {userLicensePair.Value}");
            }
        }
    }
}
