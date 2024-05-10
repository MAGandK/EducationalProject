using Lesson15.Homework;
namespace Lesson15
{
	public class Program
	{
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();

            Client client1 = new Client("Marry");
            Client client2 = new Client("Marina");
            Client client3 = new Client("Jak");


            newsProvider.SubscribeNews("Cat",client1.ReceiveNews);
            newsProvider.SubscribeNews("Car",client2.ReceiveNews);
            newsProvider.SubscribeNews("Dancing",client3.ReceiveNews);

            newsProvider.SendNews(new News("Cat", "The fluffiest cat found in Minsk."));
            newsProvider.SendNews(new News("Car", "Tesla broke the speed record."));
            newsProvider.SendNews(new News("Dancing", "The fastest dance was danced on the street..."));

           newsProvider.UnsubscribeNews("Dancing", client1.ReceiveNews);
        }
    }
}
