using System;

namespace Lesson3part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции: \n 1. Деление 3 на 3 " +
                "\n 2. Число 5 больше 3 \n 3. Небо голубое");

            var number = Int32.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Деление 3 на 3 равно 1");
            }
            if (number == 2)
            {
                Console.WriteLine("Дa, число 5 больше 3 ");
            }
            if (number == 3)
            {
                Console.WriteLine("Да, небо голубое");
            }
            else if (number != 1 && number != 2 && number != 3)
            {
                Console.WriteLine("Нет такой операции");
            }

            Console.WriteLine("*************************");

            Verchion(); //вторая попытка
        }

        static void Verchion()
        {
            Console.WriteLine("Выберите операциию");
            Console.WriteLine("1. Деление\n2. Определить четное ли число\n" +
                "3. Возведи число во вторую степень");

            var operation = Int32.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Вы выбрали деление");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали определение четное ли число");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали возведение числа во вторую степень");
                    break;
                default:
                    Console.WriteLine("Нет такой операции");
                    break;
            }
        }
    }
}