using System;

namespace Lesson3
{
    public static class TwoNumbers
    {
        public static void TwoNumbersEnter()
        {
            Console.WriteLine("Введите первое число");

            var firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            var secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Выберите номер операции");
            Console.WriteLine("1.Разделить первое число на второе." +
                "\n2.Найти какое введенное число нечетное" +
                "\n3.Эти оба числа больше 20, но меньше 100 ");
            Console.WriteLine("***************");

            var operations = Int32.Parse(Console.ReadLine());

            switch (operations)
            {
                case 1:
                    if (secondNumber != 0)
                    {
                        var result = (double)firstNumber / secondNumber;
                        Console.WriteLine("Результат деления " + result);
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    break;
                case 2:
                    if (firstNumber % 2 != 0 && secondNumber % 2 != 0)
                    {
                        Console.WriteLine("Оба числа нечетные");
                    }
                    else if (firstNumber % 2 != 0)
                    {
                        Console.WriteLine("Первое число нечетное");
                    }
                    else if(secondNumber % 2 != 0)
                    {
                        Console.WriteLine("Второе число нечетное");
                    }
                    else if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
                    {
                        Console.WriteLine("Нет нечетных чисел");
                    }
                    break;
                case 3:
                    if (firstNumber >= 20 && firstNumber <= 100 && secondNumber
                        >= 20 && secondNumber <= 100)
                    {
                        Console.WriteLine($"Да, верно {firstNumber} и {secondNumber} больше 20, но меньше 100");
                    }
                    else
                    {
                        Console.WriteLine("Нет не оба");
                    }
                    break;
                default:
                    Console.WriteLine("Некорректная операция.");
                    break;
            }

        }
    }
}