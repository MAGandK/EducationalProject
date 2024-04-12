using System;
using Lesson4.Homework;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice.Array();
            Console.WriteLine("------------");

            Console.WriteLine("Task1");
            CreateMas.Create();
            Console.WriteLine("------------");

            Console.WriteLine("Task2");
            LoopWithCounter.GetNumbers();
            Console.WriteLine("\n------------");

            Console.WriteLine("Task3");
            СolumnOfNumbers.Сolumn();
            Console.WriteLine("------------");

            Console.WriteLine("Task4");
            Move.GetMove();
            Console.WriteLine("------------");

            Console.WriteLine("Task5");
            Numbers.GetNumbers();
        }
    }
}
