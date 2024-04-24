using System;
namespace Lesson11
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, int age, string position,
            decimal salary) : base(id, name, age)
        {
            Position = position;
            Salary = salary;
        }

        public new void Display()
        {
            Console.WriteLine("Employee info:");
            base.Display();
            Console.WriteLine($", Position: {Position}, Salary: {Salary}");
        }
    }
}