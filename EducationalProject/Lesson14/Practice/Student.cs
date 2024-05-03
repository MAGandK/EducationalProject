namespace Lesson14.Practice
{
	public class Student
	{
		public string? Name {get; set;}

		public List<int> Grades;

		public Student(string name)
		{
			Name = name;
			Grades = new List<int>();
		}

		public void Add(params int[] grade)
		{
			Grades.AddRange(grade);
			Console.WriteLine($"Add { string.Join(" , ", grade)}");
		}

		public void CalculateAverageGrade()
		{
			Console.WriteLine($"Average grade student: {Grades.Average()}");
		}
	}
}
