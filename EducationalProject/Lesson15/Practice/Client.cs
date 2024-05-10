namespace Lesson15.Practice
{
	public class Client
	{
		public string Name { get; set; }


		public Client(string name)
		{
			Name = name;
		}

        public void ReceiveNews(News news) => Console.WriteLine($"{Name} получил новость {news.Category}: {news.Content}");
    }
}
