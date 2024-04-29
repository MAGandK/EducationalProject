using System;
namespace Lesson4.Homework
{
    public static class СolumnOfNumbers
    {
        public static void Сolumn()
        {
            int number = -20;

            do
            {
                Console.WriteLine(number);
                number += -20;

            } while (number <= -20 && number >= -1000);
        }
    }
}
