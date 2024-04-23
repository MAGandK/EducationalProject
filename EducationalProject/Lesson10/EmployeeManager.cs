using System;
using System.Collections.Generic;

namespace Lesson10
{
    public class EmployeeManager : ManagerManagement<Employee>, IPersonManagement<Employee>
    {
        private List<Employee> employees = new List<Employee>();

        public override void DisplayPerson(Employee person)
        {
            Console.WriteLine($"Inform about person:\nID:{person.Id},Name:{person.Name}, " +
                $"Age:{person.Age},Position:{person.Position},Salary:{person.Salary}");
        }

        public override void DisplayAll()
        {
            base.DisplayAll();
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public override void Add(Employee employee)
        {
            base.Add(employee);
        }

        public override void Remove(Employee employee)
        {
            base.Remove(employee);
        }
    }
}