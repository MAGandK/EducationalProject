namespace Lesson10
{
    public class Student : Person
    {
        public int CourseNumber { get; set; }
        public double AverageGrade { get; set; }

        public Student(int id, string name, int age, int courseNumber,
            double averageGrade): base(id, name, age)
        {
            CourseNumber = courseNumber;
            AverageGrade = averageGrade;
        }
    }
}