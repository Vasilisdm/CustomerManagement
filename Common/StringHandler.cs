using System;

namespace Common
{
    /// <summary>
    /// An extension method whichs adds spaces to a string when the first letter is upper case.
    /// </summary>
    public static class StringHandler
    {
        public static string InsertSpaces(this string inputString)
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
