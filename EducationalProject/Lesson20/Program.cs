namespace Lesson20;

class Program
{
    static async Task Main(string[] args)
    {
        var myService = new DataService();

        try
        {
            var asyncList = await myService.GetElementsAsync();

            foreach (var element in asyncList)
            {
                Console.WriteLine(element.Name);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to run. Exception: {ex.Message}");
        }
    }
}

