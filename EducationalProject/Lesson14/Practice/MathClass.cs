namespace Lesson14.Practice
{
	public static class MathClass
	{
		public static void Factorial(int number)
		{
			if (number < 0)
			{
				throw new Exception("Error!");
			}

			int result = 1;

			for (int i = 2; i <= number; i++)
			{
				result *= i;
			}

			Console.WriteLine($"Result: {result}");
		}


		public static void Power(int number, int power)
		{
			if (number == 0 && power <= 0)
			{
				throw new Exception("Invaid expression");
			}

			double result = Math.Pow(number, power);

			Console.WriteLine($"Result: {result}");
		}
	}
}
