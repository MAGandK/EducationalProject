using Lesson14.Practice;

namespace Lesson14;

class Program
{
    static void Main(string[] args)
    {
        //MathClass.Factorial(4);
        //MathClass.Power(0, -3);


        //MyClass myClass1 = new MyClass();

        //try
        //{
        //myClass.PrintMessage(null);
        //myClass.PrintMessage("Hi");
        //myClass.PrintMessage("Hello World!");
        //}
        //catch(DivideByZeroException ex)
        //{
        //    Console.WriteLine($"Divide by zero exception: { ex.Message}");
        //}
        //catch(NullReferenceException ex)
        //{
        //    Console.WriteLine($"Null reference exception: {ex.Message}");
        //}
        //catch(IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine($"Index out of range exception: { ex.Message}");
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine($"Exception: {ex.Message}");
        //}

        var myStudent = new Student("Boris") ;

        var myStudent2 = new Student("Bor");

        var myStudent3 = new Student("Bor");
        myStudent3.Add(3, 4, 5, 6);

        var students = new Student[] {myStudent, myStudent2};

        myStudent.Add(1);
        myStudent.Add();
        myStudent.Add(2, 3, 4);

        myStudent.CalculateAverageGrade();

        var myClass = new Classroom();
        myClass.AddStudents(students);

        myClass.CalculateAverageGrade();

        myClass.UpdateStudent("Bor", myStudent3);
        
    }
}
