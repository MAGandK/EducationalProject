namespace Lesson15.Practice
{
	public class NewsProvider
	{
		private Dictionary<string, List<Client>> subscribers = new ();

		public NewsProvider()
		{
			subscribers = new Dictionary<string, List<Client>>();
		}

		public void SubscribeNews(Client client, string category)
		{
			if (!subscribers.ContainsKey(category))
			{
				subscribers[category] = new List<Client>();
			}

			subscribers[category].Add(client);
		}

		public void SendNews(News news)
		{
			if (subscribers.ContainsKey(news.Category))
			{
				foreach (var client in subscribers[news.Category])
				{
					client.ReceiveNews(news);
				}
			}
		}
	}
}
