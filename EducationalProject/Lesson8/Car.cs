using System;
namespace Lesson8
{
    public class Car : Transport
    {
        private float _speed = 60f;

        public Car(string name, string kindOfTransport, float speed): base(name, kindOfTransport) 
        {
            _speed = speed;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

        public override void Park()
        {
            base.Park();
        }

        public new void Move()
        {
            base.Move();
            Console.WriteLine($"Moving with speed {_speed}");
        }
    }
}