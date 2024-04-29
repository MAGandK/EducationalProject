using System;
namespace Lesson5
{
    public static class Practice
    {
       public static void Display (int r, params int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            result *= r;

            Console.WriteLine(result);
        }
    }
}