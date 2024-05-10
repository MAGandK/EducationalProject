namespace Lesson15.Practice
{
	public class News
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
