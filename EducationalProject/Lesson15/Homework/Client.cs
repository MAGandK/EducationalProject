namespace Lesson15.Homework
{
	public class Client
	{
		public string Name { get; set; }

		public Client(string name)
		{
			Name = name;
		}

		public void ReceiveNews(News news)
		{
			Console.WriteLine($"{Name} got the news {news.Category}: {news.Content}");
		}
    }			
}
