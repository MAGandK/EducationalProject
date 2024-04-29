using System;
namespace Lesson11
{
    public class Student : Person
    {
        public int CourseNumber { get; set; }
        public double AverageGrade { get; set; }

        public Student(int id, string name, int age, int courseNumber,
            double averageGrade) : base(id, name, age)
        {
            CourseNumber = courseNumber;
            AverageGrade = averageGrade;
        }

        public new void Display()
        {
            Console.WriteLine("Student info:");
            base.Display();
            Console.WriteLine($", Course Number: {CourseNumber}, Average Grade: {AverageGrade}");
        }
    }
}