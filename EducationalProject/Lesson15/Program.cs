using Lesson15.Practice;

namespace Lesson15;

class Program
{
    static void Main(string[] args)
    {
        NewsProvider newsProvider = new NewsProvider();

        Client client1 = new Client("Tim");
        Client client2 = new Client("Mary");

        newsProvider.SubscribeNews(client1, "cat");
        newsProvider.SubscribeNews(client2, "car");

        newsProvider.SendNews(new News("cats", "angry"));

    }
}

