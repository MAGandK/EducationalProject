using System;
using System.Text;
namespace Lesson6.Homework
{
    public static class UsingStringBuilder
    {
        public static void CreatingStrings()
        {
            int firstValue = 22;
            int secondValue = 5;

            int sum = firstValue + secondValue;
            int subtraction = firstValue - secondValue;
            int multiplication = firstValue * secondValue;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(firstValue + " + " + secondValue + " = "  + sum + "\n");
            stringBuilder.Append(firstValue + " - " + secondValue + " = " + subtraction + "\n");
            stringBuilder.Append(firstValue + " * " + secondValue + " = " + multiplication + "\n");

            Console.WriteLine(stringBuilder.ToString());

            stringBuilder.Replace("=","equals");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}