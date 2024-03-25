using System;

namespace Lesson3part1
{
    class Program
    {
        static void Main(string[] args)
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