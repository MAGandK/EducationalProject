namespace Lesson16.HomeWork
{
	public static class Game
	{
        public static Dictionary<int, Character>? Characters { get; private set; }

        public static void Initialize()
        {
            Characters = new Dictionary<int, Character> {
            {   1, new Character { Name = "Player 1", Level = 4, Squad = EnumCharacter.Cook, Experience = 100, Health = 100 } },
            {   2, new Character { Name = "Player 2", Level = 6, Squad = EnumCharacter.Baker, Experience = 150, Health = 75 } },
            {   3, new Character { Name = "Player 3", Level = 10, Squad = EnumCharacter.Waiter, Experience = 200, Health = 60 } },
            {   4, new Character { Name = "Player 4", Level = 2, Squad = EnumCharacter.Washer, Experience = 250, Health = 90 } },
            {   5, new Character { Name = "Player 5", Level = 25, Squad = EnumCharacter.Cook, Experience = 300, Health = 110 } }
            };    
        }

        public static void GetAverageLevelOfEachSquad()
        {
            var result = Characters.Values.GroupBy(g => g.Squad)
                                        .ToDictionary(g => g.Key, g => g.Average(c => c.Level));

            foreach (var level in result)
            {
                Console.WriteLine($"Средний уровень для класса {level.Key}: {level.Value}");
            }
        }

        public static void GetCharacterWithHighestExperience()
        {
            var result = Characters.Values.OrderByDescending(o => o.Experience).First();

            Console.WriteLine($"У игрока {result.Name} наибольший опыт: {result.Experience}");
        }

        public static void GetPercentageOfEachSquad()
        {

            int totalCharacters = Characters.Values.Count();
            Console.WriteLine($"Total characters: {totalCharacters}");

            var result = Characters.Values.GroupBy(g => g.Squad).
                                            ToDictionary(g => g.Key, g => ((double)g.Count() / totalCharacters) * 100);

            foreach (var item in result)
            {
                Console.WriteLine($"Процент персонажей класса: {item.Key} : {item.Value}%");
            }

        }

        public static void GetSummHealthOfEachLevel()
        {
            var result = Characters.Values.GroupBy(g => g.Squad).
                                    ToDictionary(g => g.Key, g => g.Sum(c => c.Health));

            foreach (var item in result)
            {
                Console.WriteLine($"Сумарное здоровье персонажей {item.Key} для каждого уровня {item.Value}");
            }
        }

        public static void GetSquadWithHighestAverageHealth()
        {
            var result = Characters.Values.GroupBy(g => g.Squad).OrderByDescending(g => g.Average(g => g.Health)).
                                                First().Key;

            Console.WriteLine($"Класс с наивысшим средним здоровьем: {result}");
        }
    }
}
