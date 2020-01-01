using System;

namespace Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(string inputString)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(inputString))
            {
                foreach (char letter in inputString)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            return result.Trim();
        }
    }
}
