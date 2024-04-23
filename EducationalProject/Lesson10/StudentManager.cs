using System;
using System.Collections.Generic;

namespace Lesson10
{
    public class StudentManager : ManagerManagement<Student>, IPersonManagement<Student>
    {
        List<Student> students = new List<Student>();

        public override void DisplayPerson(Student student)
        {
            Console.WriteLine($"Inform about student:\nID:{student.Id},Name:{student.Name}, " +
                $"Age:{student.Age},Average grade:{student.AverageGrade},Course number:{student.CourseNumber}");
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public override void DisplayAll()
        {
            base.DisplayAll();
        }

        public override void Add(Student student)
        {
            base.Add(student);
        }

        public override void Remove(Student student)
        {
            base.Remove(student);
        }
    }
}