using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            bool isLengthValid = IsPasswordLengthValid(inputPassword);
            bool isPasswordAlphaNumeric = IsPasswordAlphaNumeric(inputPassword);
            bool isPasswordContainingAtLeast2Digits = IsPasswordContainingAtLeast2Digits(inputPassword);
            if(!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if(!isPasswordAlphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isPasswordContainingAtLeast2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if(isLengthValid && isPasswordAlphaNumeric && isPasswordContainingAtLeast2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPasswordLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool IsPasswordAlphaNumeric(string password)
        {
            //Alphanumeric- a-z/A-Z and 0-9
            foreach(char letter in password)
            {
                if (!Char.IsLetterOrDigit(letter))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPasswordContainingAtLeast2Digits(string password)
        {
            int digitsCount = 0;
            foreach (char letter in password)
            {
                if(Char.IsDigit(letter))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= 2;
        }

    }
}
