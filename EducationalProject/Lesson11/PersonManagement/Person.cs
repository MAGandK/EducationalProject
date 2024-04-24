using System;
namespace Lesson11
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public virtual void Display()
        {
            Console.Write($"Id: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}