using System;
using System.Data;
using Lesson22.Practice;
namespace Lesson22;

class Program
{
    static void Main(string[] args)
    {
        //Try();

        int a = 12;
        int b = 13;

        //object objA = a;
        //object objB = b;

        bool equalsResult = a.Equals(b);
        Console.WriteLine("Equals result: " + equalsResult);

        bool equalityOperatorResult = (a == b);
        Console.WriteLine("Equality operator result: " + equalityOperatorResult);


        Type typeA = a.GetType();
        Type typeB = b.GetType();

        Console.WriteLine(typeA);
        Console.WriteLine(typeB);

        Type type2 = typeof(string);


        //public static void Try()
        //{ 

        //try
        //{
        //    Console.WriteLine("Ввести число");
        //    throw new Exception("Ex");
        //}
        //catch
        //{
        //    Console.WriteLine(" число");
        //    return;
        //}
        //finally
        //{
        //    Console.WriteLine("слово");
        //}

        //ArrayInt.GetArray();

        //RandString.ProcessStringArray();


    //    Events events = new Events();


    //    events.MetodCallTen += (sender, e) =>
    //    {
    //        Console.WriteLine("Вызвано событие");
    //    };

    //    for (int i = 0; i <= 10; i++)
    //    {
    //        events.Test();
    //    }

    //    Events events1 = new Events();


    //    events.MetodCallTen += (sender, e) =>
    //    {
    //        Console.WriteLine("Вызвано событие");
    //    };

    //    for (int i = 0; i <= 9; i++)
    //    {
    //        events.Test();
    //    }

    //    for (int i = 0; i <= 9; i++)
    //    {
    //        events1.Test();
    //    }



    //    IDataStorage<Project> myProject = new JSONDateStorage<Project>();

    //    var myProjectList = new List<Project>
    //    {
    //        new Project() { Id = 1, Name = "First", CreateData = DateTime.Now },
    //        new Project() { Id = 2, Name = "Second", CreateData = DateTime.Now},
    //        new Project() { Id = 3, Name = "Good", CreateData = DateTime.Now },
    //        new Project() { Id = 4, Name = "Bad", CreateData = DateTime.Now },
    //    };

    //   // myProject.Save(myProject,)

    //    ICRUDOperations<Project> operations = new MemoryCRUDOperations<Project>();

    //    operations.Create(myProjectList[0]);
    //    operations.Create(myProjectList[3]);
    //    var readOperations = operations.Read();
    //    foreach (var project in readOperations)
    //    {
    //        Console.WriteLine($"Id: {project.Id}, Name: {project.Name}, CreateData: {project.CreateData}");
    //    }

    }
}

