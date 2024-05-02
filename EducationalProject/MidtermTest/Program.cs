using MidtermTest.Task7;

namespace MidtermTest;

class Program
{
    static void Main(string[] args)
    {
       //TaskArray.AddChar();

       //StringBuilder sb = new StringBuilder("Hello world!");
       //Console.WriteLine("Original string: " + sb);

       //sb.ToUpperString();
       //Console.WriteLine("Modified string: " + sb);

       // MyString str1 = new MyString();

       // str1.Reverse();

        CarBace car1 = new CarFord("Ford", 1, "blak", false);
        CarBace car2 = new CarAudi("Audi", 2, 4);

        car1.ShowInfo();
        car2.ShowInfo();
    }
}