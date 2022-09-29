using System;

namespace Decrypt_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            string decryptedMessage = "";
            for (int i = 1; i <= n; i++)
            {
                char symbols = char.Parse(Console.ReadLine());
                decryptedMessage += (char)(symbols + key);
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
