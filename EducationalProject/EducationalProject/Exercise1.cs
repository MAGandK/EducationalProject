using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 8;
            int d = 4;
            int e = 5;

            int max = a;

            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if (d > max)
            {
                max = d;
            }
            if (e > max)
            {
                max = e;
            }

            Console.WriteLine(max);

            //ввод с консоли
            Console.WriteLine("**********************");
            Console.WriteLine("Введите 5 целых чисел");
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string c1 = Console.ReadLine();
            string d1 = Console.ReadLine();
            string e1 = Console.ReadLine();

            int num1 = Int32.Parse(a1);
            int num2 = Int32.Parse(b1);
            int num3 = Int32.Parse(c1);
            int num4 = Int32.Parse(d1);
            int num5 = Int32.Parse(e1);

            int maximal = num1;
            if (num2 > maximal)
            {
                maximal = num2;
            }
            if (num3 > maximal)
            {
                maximal = num3;
            }
            if (num4 > maximal)
            {
                maximal = num4;
            }
            if (num5 > maximal)
            {
                maximal = num5;
            }

            Console.WriteLine($"Максимальное число равно: {maximal}");
        }
    }    
}