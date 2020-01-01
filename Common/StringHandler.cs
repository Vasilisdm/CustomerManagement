using System;

namespace Common
{
    public class StringHandler
    {
        public string InsertSpaces(string inputString)
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
