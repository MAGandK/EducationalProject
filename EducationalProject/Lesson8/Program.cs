using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transportFirst = new Boat("Titanik", "catamaran");

            transportFirst.ShowInfo();
            transportFirst.Move();
            transportFirst.Park();

            Transport transportSecond = new Car("Ford", "SUV", 60);

            transportSecond.ShowInfo();
            transportSecond.Move();
            transportSecond.Park();

            Car car = new Car("Ferarri", "Sportcar", 120);
            car.ShowInfo();
            car.Move();
            car.Park();

            Boat boat = new Boat("Red", "boat");
            boat.ShowInfo();
            boat.Move();
            boat.Park();
        }
    }
}