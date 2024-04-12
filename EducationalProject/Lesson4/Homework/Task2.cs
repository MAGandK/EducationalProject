using System;
namespace Lesson4.Homework
{
    public static class LoopWithCounter
    {
        public static void GetNumbers()
        {
            for (int i = 10; i<= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}