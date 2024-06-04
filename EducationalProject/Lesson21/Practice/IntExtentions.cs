using System.Text;

namespace Lesson21.Practice
{
	public static class IntExtentions
	{
		public static StringBuilder ToWords(this int number)
		{
			string[] words = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

			string convertIntToString = Convert.ToString(number);

			StringBuilder resuilConvert = new StringBuilder();

			foreach (char digit in convertIntToString)
			{
				if (char.IsDigit(digit))
				{

					int intSupport = digit - '0';

					resuilConvert.Append(words[intSupport] + " ");
				}
				else
				{
					throw new ArgumentException("Введеный символ не являются цифрой");
				}
			}

			return resuilConvert;
		}
	}
}

