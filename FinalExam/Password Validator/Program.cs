using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder enterPassword = new StringBuilder(Console.ReadLine());
            string command;
            int countOfUpper = 0;
            int countOfLower = 0;
            int countOfNumbers = 0;

            while ((command = Console.ReadLine())!= "Complete")
            {
                string[] commands = command.Split(" ");
                string commandType = commands[0];

                if(commands[0] == "Make")
                {
                    if(commands[1] == "Upper")
                    {
                        int index = int.Parse(commands[2]);

                        string substring = enterPassword[index].ToString();
                        enterPassword = enterPassword.Insert(index, substring.ToUpper());
                        enterPassword.Remove(index + 1, 1);

                        Console.WriteLine(enterPassword.ToString());
                    }
                    else if (commands[1] == "Lower")
                    {
                        int index = int.Parse(commands[2]);
                        string substring = enterPassword[index].ToString();

                        enterPassword = enterPassword.Insert(index, substring.ToLower());
                        enterPassword.Remove(index + 1, 1);

                        Console.WriteLine(enterPassword.ToString());
                    }
                    
                }
                else if (commandType == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    char symbol = char.Parse(commands[2]);

                    if(index<0 || index >= enterPassword.Length)
                    {
                        continue;
                    }

                    enterPassword = enterPassword.Insert(index, symbol);
                    Console.WriteLine(enterPassword.ToString());
                }
                else if (commandType == "Replace")
                {
                    char symbol = char.Parse(commands[1]);

                    if(!enterPassword.ToString().Contains(symbol))
                    {
                        continue;
                    }

                    int value = int.Parse(commands[2]);
                    int valueOfTheSymbol = (int)symbol;
                    int sum = valueOfTheSymbol+value;
                    char symbolOfTheirSum = (char)sum;

                    enterPassword = enterPassword.Replace(symbol, symbolOfTheirSum);
                    Console.WriteLine(enterPassword.ToString());
                }
                else if (commandType == "Validation")
                {
                    if(enterPassword.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    foreach (char letter in enterPassword.ToString())
                    {
                        if(!(char.IsLetterOrDigit(letter) || letter == '_'))
                        {
                            Console.WriteLine("Password must consist only of letters, digits and _!");
                            break;
                        }
                        else
                        {
                            if (char.IsDigit(letter))
                            {
                                countOfNumbers++;
                            }
                            else if (letter.ToString() == letter.ToString().ToUpper())
                            {
                                countOfUpper++;
                            }
                            else if (letter.ToString() == letter.ToString().ToLower())
                            {
                                countOfLower++;
                            }
                        }
                    }
                 
                    if (countOfUpper<1)
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }

                    if(countOfLower<1)
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }

                    if(countOfNumbers<1)
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                    
                    

                }
            }
        }
    }
}
