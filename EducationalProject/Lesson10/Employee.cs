namespace Lesson10
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee (int id, string name, int age, string position,
            decimal salary): base(id, name, age)
        {
            Position = position;
            Salary = salary;
        }
    }
}