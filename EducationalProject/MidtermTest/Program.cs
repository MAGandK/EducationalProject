using System.Text;

namespace MidtermTest;

class Program
{
    static void Main(string[] args)
    {
       TaskArray.AddChar();

       StringBuilder sb = new StringBuilder("Hello world!");
       Console.WriteLine("Original string: " + sb);

       sb.ToUpperString();
       Console.WriteLine("Modified string: " + sb);

        MyString str1 = new MyString();

        str1.Reverse();
    }
}

