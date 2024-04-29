using System;

namespace Lesson3
{
    public static class NumberGreater
    {
        public static void NumbersGreater()
        {
            Console.WriteLine("Enter the number");

            var number = Int32.Parse(Console.ReadLine());

            if (number > 5 && number < 10)
            {
                Console.WriteLine("Number greater than 5 and less than 10");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }
        }
    }
}