namespace Lesson20
{
	public class DataService
	{
		public List<Element> Elements { get; set; }

		public async Task<List<Element>> GetElementsAsync()
		{
			await Task.Delay(5000);

			return  new List<Element>
			{
				new Element() { Name = "Name1" },
				new Element() { Name = "Name2" },
				new Element() { Name = "Name3" },
				new Element() { Name = "Name4" }
			};
		}
	}
}
