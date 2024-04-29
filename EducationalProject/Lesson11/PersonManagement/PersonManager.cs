using System;
using System.Collections.Generic;

namespace Lesson11
{
    public class PersonManager<T> : IPersonManagement<Person>
    {
        private List<Person> people = new List<Person>();

        public void Add(Person person)
        {
            people.Add(person);

            Console.WriteLine($"Person {person.Name} added successfully.");
        }

        public void Remove(int id)
        {
            Person? personToRemove = people.Find(p => p.Id == id);

            if (personToRemove != null)
            {
                people.Remove(personToRemove);
                Console.WriteLine($"Person {personToRemove.Name} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Person with ID {id} not found.");
            }
        }

        public void Update(int id, string name, int age, Person person)
        {
            Person? personToUpdate = people.Find(p => p.Id == id);

            if (personToUpdate != null)
            {
                personToUpdate.Name = name;
                personToUpdate.Age = age;
                Console.WriteLine($"Person updated sucessfully {personToUpdate.Name}, {personToUpdate.Age}");

                if (personToUpdate is Employee && person is Employee)
                {
                    var employee = personToUpdate as Employee;
                    var newEmployee = person as Employee;
                    employee.Position = newEmployee.Position;
                    employee.Salary = newEmployee.Salary;
                    Console.WriteLine($"Employee updated successfully:\n Position:{employee.Position}, Salary:{employee.Salary}");
                }
                else if (personToUpdate is Student && person is Student)
                {
                    var student = personToUpdate as Student;
                    var newStudent = person as Student;
                    student.CourseNumber = newStudent.CourseNumber;
                    student.AverageGrade = newStudent.AverageGrade;
                    Console.WriteLine($"Student updated successfully:\n Course Number:{student.CourseNumber}, Average Grade:{student.AverageGrade}");
                }
            }
            else
            {
                Console.WriteLine($"Person with ID {id} not found.");
            }
        }

        public void Display(Person person)
        {
            if (person is Employee)
            {
                var employee = person as Employee;
                employee.Display();
            }
            else if (person is Student)
            {
                var student = person as Student;
                student.Display();
            }
            else
            {
                person.Display();
            }
        }

        public List<Person> DisplayAll()
        {
            foreach (Person person in people)
            {
                Display(person);
            }

            return people;
        }
    }
}