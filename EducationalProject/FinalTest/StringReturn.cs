using System;
using System.Text;

namespace FinalTest
{
    public static class StringReturn
    {
        public static string ReplaceVowels(this StringBuilder input)
        {
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i].ToString()))
                {
                    input[i] = '*';
                }
            }

            return input.ToString();
        }
    }
}



