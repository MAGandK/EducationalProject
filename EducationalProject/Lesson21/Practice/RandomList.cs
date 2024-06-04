namespace Lesson21.Practice
{
	public static class RandomList
	{
		public static void Run()
		{
			List<int> numbers = new List<int>();

			var random = new Random();

			for (int i = 0; i < 5; i++)
			{
				numbers.Add(random.Next(1,5));
			}

			var stringNumber = string.Join(" ", numbers);

			Console.WriteLine(stringNumber);

			var orderedNumbers = numbers.OrderBy(n => n).ToList();

			int center = (int)Math.Ceiling(orderedNumbers.Count/2.0);

			Console.WriteLine(center);

			var secondHalf = orderedNumbers.Skip(center);

			var result = secondHalf
				.OrderByDescending(n => n)
				.Select(n => new {OldValue = n, NewValue = n * n });

			foreach (var number in result)
			{
				Console.WriteLine($"Оригинальное число: {number.OldValue}, квадрат часла {number.NewValue}");
			}

			Console.WriteLine(string.Join(" ", result));

        }
	}
}

