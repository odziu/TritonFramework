using System;
using System.Linq;

namespace Framework.Helpers
{
    public static class RandomStringGenerators
    {
        public static string CreateRandomString(int length)
        {
            const string chars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            Random rd = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rd.Next(s.Length)]).ToArray());
        }

        // !!! I want to save this code for example !!!
        /*
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
        */
    }
}
