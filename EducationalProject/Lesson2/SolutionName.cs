using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();

            if (name.ToLower() == "ann")
            {
                Console.WriteLine("Hello my star Ann");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
}
