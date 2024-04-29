using System;

namespace Lesson3
{
    public static class EvenNumber
    {
        public static void EvenNumbers()
        {
            Console.WriteLine("Enter the number");

            var number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The entered number is even");
            }
            else
            {
                Console.WriteLine("The entered number is odd");
            }
        }
    }
}