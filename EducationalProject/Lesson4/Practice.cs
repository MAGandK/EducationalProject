using System;
namespace Lesson4
{
    public static class Practice
    {
        public static void Array()
        {
            int j = 2;

            int count = 0;

            for (int i = 1; i < 100; i = i + 2)
            {
                j = j - 1;

                count++;

                while (j < 15)
                {
                    j = j + 5;
                }
            }

            Console.WriteLine(count);
        }
    }
}
