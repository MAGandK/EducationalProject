using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentManager = new StudentManager();
            studentManager.Add(new Student(345, "Sergey", 30, 5, 5.67));
            studentManager.Add(new Student(3, "Denis", 21, 3, 7));

            studentManager.DisplayAll();

            studentManager.Remove(new Student(3, "Denis", 21, 3, 7.8));


            var employeeManager = new EmployeeManager();
            employeeManager.Add(new Employee(453, "Maria", 32, "3D artist", 600));
            employeeManager.Add(new Employee(876, "Еgor", 38, "3D Lid artist", 1600));

            employeeManager.DisplayAll();
        }
    }
}
