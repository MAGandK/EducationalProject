using System;
namespace Lesson9
{
    public class Employee : Person
    {
        public string Position { get; set; }

        public int Experience { get; set; }

        public override int GetYear()
        {
            return Convert.ToInt32(DateTime.Now.Year) - Experience;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee info: {Position} {Experience} {GetYear()}");
        }
    }
}