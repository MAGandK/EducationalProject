namespace FinalTest
{
	public class MathFunctions
	{
        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public static double Square(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Квадрат числа определен только для неотрицательных чисел.");
            }

            return Math.Sqrt(x);
        }
    }
}


