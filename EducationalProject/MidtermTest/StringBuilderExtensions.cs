using System.Text;

namespace MidtermTest
{
	public static class StringBuilderExtensions
	{
        public static void ToUpperString(this StringBuilder stringBuilder)
        {
            string vowels = "aeiouAEIOU"; 

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (vowels.Contains(stringBuilder[i]))
                {
                    stringBuilder[i] = char.ToUpper(stringBuilder[i]);
                }
            }
        }
    }
}