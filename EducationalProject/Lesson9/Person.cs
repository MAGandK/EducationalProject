using System;
namespace Lesson9
{
    public abstract class Person
    {
        public  string Name { get; set; }

        public  int Age { get; set; }

        public string Mail { get; set; }

        public  string FavouriteFilm { get; set; }

        public abstract int GetYear();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name};\nAge: {Age};\nMail: {Mail};\nFavourite: {FavouriteFilm}");
        }
    }
}