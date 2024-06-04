using System.Text;

namespace FinalTest;

class Program
{
    static void Main(string[] args)
    {
        Array.FillArray();

        StringBuilder sb = new StringBuilder("How are you doing?!");
        string result = StringReturn.ReplaceVowels(sb);
        Console.WriteLine(result);

        Elements.GetElement();
    }
}

