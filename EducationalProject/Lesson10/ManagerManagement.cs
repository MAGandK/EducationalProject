using System;
using System.Collections.Generic;

namespace Lesson10
{
    public class ManagerManagement<T> where T : Person
    {
        private List<T> people = new List<T>();

        public virtual void DisplayPerson(T person)
        {
            Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, " +
                $"Age: {person.Age}");          
        }
 
        public virtual void DisplayAll()
        {
            foreach (var person in people)
            {
                DisplayPerson(person);
            }
        }

        public virtual void Add(T person)
        {
            people.Add(person);
        }

        public virtual void Remove(T person)
        {
            people.Remove(person);
        }
    }
}