using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises exercises = new Exercises();

            //string[] words = { "pay", "attention", "practice", "attend" };
            //string pref = "at";

            //exercises.FindAtPrefix(words, pref);

            //exercises.StringShuffle("tenstdu", new int[] { 3, 4, 6, 5, 1, 2, 0 });

            //exercises.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });

            //string wordReverse = "hellO";

            //exercises.ReverseVowels(wordReverse);

            var personManager = new PersonManager<Person>();

            var student = new Student(43, "Roma", 17, 1, 5.8);

            var employee = new Employee(32, "Tima", 43, "Gem designer", 1500);

            student.Display();

            employee.Display();

            personManager.Add(new Student(4, "Dima", 19, 3, 7.8));
            personManager.Add(new Student(5, "Olya", 17, 1, 8.9));
            personManager.Add(new Student(6, "Alex", 18, 2, 6.75));

            personManager.DisplayAll();

            personManager.Add(new Employee(1, "Rita", 25, "UI/UX designer", 200));
            personManager.Add(new Employee(2, "Max", 28, "Developer", 250));
            personManager.Add(new Employee(3, "Tim", 18, "Gem designer", 150));


            personManager.Remove(5);

            Console.WriteLine("After removed");
            personManager.DisplayAll();


            personManager.Update(3, "Tim", 20, student);

            Console.WriteLine("After updated");
            personManager.DisplayAll();
        }
    }
}