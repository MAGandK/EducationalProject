namespace FinalTest;

class Program
{
    static void Main(string[] args)
    {
        //Array.FillArray();

        //StringBuilder sb = new StringBuilder("How are you doing?!");
        //string result = StringReturn.ReplaceVowels(sb);
        //Console.WriteLine(result);

        //Elements.GetElement();

        try
        {
            int n = 5;
            long factorial = MathFunctions.Factorial(n);
            Console.WriteLine($"Факториал числа {n} равен {factorial}");

            double x = 3;
            double y = 2;
            double power = MathFunctions.Power(x, y);
            Console.WriteLine($"{x} в степени {y} равно {power}");

            double number = 9;
            double squareRoot = MathFunctions.Square(number);
            Console.WriteLine($"Корень из {number} равен {squareRoot}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
        }
    }
}


