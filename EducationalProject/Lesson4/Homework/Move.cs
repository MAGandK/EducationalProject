using System;

namespace Lesson4.Homework
{
    public static class Move
    {
        public static void GetMove()
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                switch (info.Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("\nMoving up");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("\nMoving down");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("\nMoving the left");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("\nMoving the rigth");
                        break;
                    default:
                        Console.WriteLine("\nThere is't such direction");
                        break;
                }
            }
        }
    }
}