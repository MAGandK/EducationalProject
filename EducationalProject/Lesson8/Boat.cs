using System;
namespace Lesson8
{
    public class Boat : Transport
    {
        public Boat(string name, string kindOfTransport) : base(name, kindOfTransport)
        {
          
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

        public override void Move()
        {
            Console.WriteLine("Floating on the waves");
        }

        public new void Park()
        {
            Console.WriteLine("I don't can parking, only mooring");
        }
    }
}