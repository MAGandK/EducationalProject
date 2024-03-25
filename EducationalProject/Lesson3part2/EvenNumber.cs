using System;

namespace Lesson3part2
{
    class Program
    {
        static void Main(string[] args)
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
