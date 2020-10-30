using System;

namespace BasicStructures
{
    public static class StringUtils
    {
        public static string Clean(string inputString)
        {
            inputString = inputString.Trim();
            var split = inputString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return string.Join(" ", split);
        }
        
        public static int CountVowels(string inputString)
        {
            var temp = inputString
                .Replace("a", "")
                .Replace("e", "")
                .Replace("i", "")
                .Replace("o", "")
                .Replace("u", "")
                .Replace("y", "");

            return inputString.Length - temp.Length;
        }
    }
}
