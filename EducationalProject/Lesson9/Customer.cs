using System;
namespace Lesson9
{
    public class Customer : Person
    {
        public string Adress { get; set; }

        public Customer(string name, int age, string mail, string favouriteFilm, string adress)
        {
            Name = name;
            Age = age;
            Mail = mail;
            FavouriteFilm = favouriteFilm;
            Adress = adress;

        }

        public override int GetYear()
        {
            return DateTime.Now.Year - Age;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Adress: {Adress}\n Year of birth:{GetYear()}");
        }

        public void FavoriteFilm()
        {
            Console.WriteLine($"Favourite films is {FavouriteFilm}");
        }
    }
}