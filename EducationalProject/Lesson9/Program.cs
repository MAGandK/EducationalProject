using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ilya = new Employee();
            var Kirill = new Customer("Kirill", 37, "kirril@.com", "Начало", "Минск");

            Ilya.Name = "Ilya";
            Ilya.Age = 23;
            Ilya.Mail = "Shelk";
            Ilya.Position = "Lead";

            Ilya.DisplayInfo();

            Kirill.DisplayInfo();
            Console.WriteLine();
            Kirill.FavoriteFilm();
        }
    }
}