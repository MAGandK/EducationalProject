using System;

namespace AverageValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1");

            string num1String = Console.ReadLine();

            Console.WriteLine("Enter the number 2");

            string num2String = Console.ReadLine();

            Console.WriteLine("Enter the number 3");

            string num3String = Console.ReadLine();

            float num1 = Int32.Parse(num1String);
            float num2 = Int32.Parse(num2String);
            float num3 = Int32.Parse(num3String);

            float result = (num1 + num2 + num3) / 3;

            Console.WriteLine($"Average value: {result}");
        }
    }
}
