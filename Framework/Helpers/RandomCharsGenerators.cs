using System;
using OpenQA.Selenium;

namespace Framework.Helpers
{
    public static class RandomCharsGenerators
    {
        public static string CreateRandomChars(int textLength)
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            char[] chars = new char[textLength];
            Random rd = new Random();

            for (int i = 0; i < textLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}
