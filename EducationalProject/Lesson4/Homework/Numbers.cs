using System;
namespace Lesson4.Homework
{
    public static class Numbers
    {
        public static void GetNumbers()
        {
            Console.WriteLine("Enter numbers separated by commas");

            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            int countPositiveNumber = 0;
            int countNegativeNumber = 0;
            int countZero = 0;

            foreach (string numberStr in numbers)
            {
                int number = int.Parse(numberStr); 

                if (number > 0)
                {
                    countPositiveNumber++;
                }
                else if (number < 0)
                {
                    countNegativeNumber++;
                }
                else if(number ==0)
                {
                    countZero++;
                }
            }

            Console.WriteLine("Number of positive numbers: " + countPositiveNumber);
            Console.WriteLine("Number of negative numbers: " + countNegativeNumber);
            Console.WriteLine("Number of zeros: " + countZero);
        }
    }
}