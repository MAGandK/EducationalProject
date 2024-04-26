using System;
namespace MidtermTest
{
    public class MyString
    {
        private char[] world;

        public MyString()
        {
            world = new char[0];
        }

        public MyString(string str)
        {
            world = str.ToCharArray();
        }

        public void Reverse()
        {
            Array.Reverse(world);
        }
    }
}