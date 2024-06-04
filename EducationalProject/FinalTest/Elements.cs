namespace FinalTest
{
	public static class Elements
	{
        public static void GetElement()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            {"good", 10},
            {"banana", 5},
            {"great", 15},
            {"date", 8},
        };

            var sortedCollection = dictionary.OrderBy(pair => pair.Value);

            int halfCount = (int)Math.Ceiling(dictionary.Count / 2.0);

            var firstHalf = sortedCollection.Take(halfCount);

            var sortedFirstHalf = firstHalf.OrderByDescending(pair => pair.Key);

            var multipliedFirstHalf = sortedFirstHalf.Select(pair => new KeyValuePair<string, int>(pair.Key, pair.Value * (pair.Value + 1)));

            foreach (var pair in multipliedFirstHalf)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}

