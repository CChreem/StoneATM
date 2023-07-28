using System;

namespace StoneATM.Utils
{
    public sealed class PasswordUtils
    {
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true); 
                if (keyInfo.Key != ConsoleKey.Enter)
                {
                    password += keyInfo.KeyChar;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            return password;
        }
    }
}