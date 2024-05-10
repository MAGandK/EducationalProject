namespace Lesson15.Homework
{
    public class News : EventArgs
	{
		public string Category { get; set; }
        public string Content { get; set; }

		public News(string category, string content)
		{
			Category = category;
			Content = content;
		}
	}
}
