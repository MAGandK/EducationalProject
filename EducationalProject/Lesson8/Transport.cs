using System;
namespace Lesson8
{
    abstract class Transport
    {
        public string Name { get; set; }
        public string KindOfTransport { get; set; }

        public Transport(string name, string kindOfTransport)
        {
            Name = name;
            KindOfTransport = kindOfTransport;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, KindOfTransport: {KindOfTransport}");
        }

        public virtual void Move()
        {
            Console.WriteLine("Moving");
        }

        public virtual void Park()
        {
            Console.WriteLine("Parking");
        }
    }
}