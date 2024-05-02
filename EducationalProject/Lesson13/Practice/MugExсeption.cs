namespace Lesson13
{
	public class MugExсeption: Exception
	{
		public int Value { get; set; }

		public MugExсeption(string massage, int value): base(massage)
		{
			Value = value;
		}
    }
}