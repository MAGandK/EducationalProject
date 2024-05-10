using System;
namespace Lesson14.Practice
{
	public class Classroom
	{
		private List<Student> _students = new();

		public void AddStudent(Student student)
		{
			_students.Add(student);
		}

		public void AddStudents(Student[] students)
		{
			foreach (Student student in students)
			{
				AddStudent(student);
			}
		}

		public void RemoveStudent(string name)
		{
			var studentToRemove = _students.Find(x => x.Name == name);

			if (studentToRemove != null)
			{
				_students.Remove(studentToRemove);
			}
			else
			{
				Console.WriteLine($"There is no student with this {name} on the list");
			}
		}

		public void CalculateAverageGrade()
		{

			if (_students.Count == 0 )
			{
				Console.WriteLine("The list is empty");
				return;
			}

			Console.WriteLine($"Average grades in classroom:  {_students.SelectMany(s => s.Grades).Average()}");
			
        }

		public void UpdateStudent(string name, Student newStudent)
		{
            var studentToUpdate = _students.Find(x => x.Name == name);

            if (studentToUpdate != null)
            {
                studentToUpdate.Name = newStudent.Name;
                studentToUpdate.Grades = newStudent.Grades;
                Console.WriteLine($"Student {name} updated");
            }
            else
            {
                Console.WriteLine($"Student {name} not found");
            }
			 
        }
	}
}
