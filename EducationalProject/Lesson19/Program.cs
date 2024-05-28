namespace Lesson19;

class Program
{
    static void Main(string[] args)
    {
        Factorial.RunThread();

        Console.WriteLine();
        
        Factorial.RunThreadPool();
    }
}

