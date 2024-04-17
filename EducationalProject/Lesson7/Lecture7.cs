using System;
using System.Collections.Generic;

namespace Lesson7
{
    public class Lecture7
    {
        private List<string> students = new List<string>();
        private Dictionary<string, double> grades = new Dictionary<string, double>();

        public void AddStudent(string studentName)
        {
            if (!students.Contains(studentName))
            {
                students.Add(studentName);
            }
            else
            {
                Console.WriteLine($"Студент {studentName} уже присутствует на лекции.");
            }
        }

        public void RemoveStudent(string studentName)
        {
            if (students.Contains(studentName))
            {
                students.Remove(studentName);
                grades.Remove(studentName);
            }
            else
            {
                Console.WriteLine($"Студент {studentName} отсутствует на лекции.");
            }
        }

        public void AddGrade(string studentName, double grade)
        {
            if (students.Contains(studentName))
            {
                grades[studentName] = grade;
            }
            else
            {
                Console.WriteLine($"Студент {studentName} отсутствует на лекции.");
            }
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Студенты на лекции:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void DisplayGrades()
        {
            Console.WriteLine("Оценки студентов:");
            foreach (KeyValuePair<string, double> entry in grades)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
