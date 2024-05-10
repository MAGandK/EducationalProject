namespace Lesson15.Homework
{
	public class NewsProvider
	{
        private Dictionary<string, NewsReceivedEventHandler> subscribers = new ();

        public delegate void NewsReceivedEventHandler(News news);

		public event NewsReceivedEventHandler NewsReceived;

		public void SubscribeNews(string category,NewsReceivedEventHandler handler)
		{
            if (!subscribers.ContainsKey(category))
            {
                subscribers[category] = handler;
            }
            else
            {
                subscribers[category] += handler;
            }
        }

        public void UnsubscribeNews(string category,NewsReceivedEventHandler handler)
        {
            if (subscribers.ContainsKey(category))
            {
                subscribers[category] -= handler;
                Console.WriteLine($"The client unsubscribed from the news in the category: {category}");
            }
        }

        public void SendNews(News news)
        {
            if (subscribers.ContainsKey(news.Category))
            {
                subscribers[news.Category]?.Invoke(news);
            }
        }
    }
}
