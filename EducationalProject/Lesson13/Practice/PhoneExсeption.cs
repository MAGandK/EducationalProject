namespace Lesson13
{
	public class PhoneExсeption : Exception
	{
        public string Value { get; set; }

        public PhoneExсeption(string message, string value) : base(message)
        {
            Value = value;
        }
    }
}