using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int invalidLoginCount = 1;
            for(int i = username.Length-1;i>=0;i--)
            {
                char currCh = username[i];
                password += currCh;
            }
            string enteredPasswords;
            while((enteredPasswords = Console.ReadLine())!=password)
            {
                
                if(invalidLoginCount>=4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                invalidLoginCount++;
            }
            if(invalidLoginCount < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
