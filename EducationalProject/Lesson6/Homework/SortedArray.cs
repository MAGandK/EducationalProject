using System;
namespace Lesson6.Homework
{
    public static class SortedArray
    {
        public static void SortedArrayNum()
        {
            int[] numberArray = new int[6];

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write($"Enter the numbers for array at index {i}: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numberArray);
            Array.Reverse(numberArray);

            Console.WriteLine("Array output");

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);  
            }  
        }

        public static void SecondWaySortedArray()
        {
            int[] numberArray = new int[6];

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write($"Enter the numbers for array at index {i}: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array output");

            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                for (int j = 0; j < numberArray.Length - 1 - i; j++)
                {
                    if (numberArray[j] < numberArray[j + 1])
                    {
                        int temp = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
        }
    }
}