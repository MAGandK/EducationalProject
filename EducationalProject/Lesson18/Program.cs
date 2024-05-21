using Lesson18.HomeWork;

namespace Lesson18;

class Program
{
    static void Main(string[] args)
    {
        List<GameCompany> gameCompanies = new List<GameCompany>
        {
            new GameCompany { Name = "Nintendo", YearOfFoundation = 1989,
                Game = new Game {GameName = "Super Mariо", ReleaseYear = 1985 } },
            new GameCompany { Name = "Epic Games", YearOfFoundation = 1991,
                Game = new Game {GameName = "Fortnite", ReleaseYear = 2017 } },
            new GameCompany { Name = "Ubisoft", YearOfFoundation = 1986,
                Game = new Game {GameName = "Assassins Creed", ReleaseYear = 2007 } }
        };

        ISerialiser<GameCompany> gameCompanySerializer = new ISerialiser<GameCompany>();
        gameCompanySerializer.Serialize(gameCompanies, "gameCompanyName");


       string fileName = "/Users/admin/EducationalProject/EducationalProject/gameCompanyName.json";
        List<GameCompany> deserializedCompanies = gameCompanySerializer.Deserialize(fileName);

        Console.WriteLine("Deserialized JSON:");
        foreach (var company in deserializedCompanies)
        {
           Console.WriteLine($"Name: {company.Name}, Year Of Foundation: {company.YearOfFoundation}, " +
               $"Game: {company.Game.GameName}, Release Year: {company.Game.ReleaseYear}");
        }


        Console.WriteLine("Enter info about new company.");
        Console.WriteLine("Name:");
        string newName = Console.ReadLine();
        Console.WriteLine("Year of foundation");
        int newYearOfFoundation = int.Parse(Console.ReadLine());
        Console.WriteLine("GameName");
        string newGameName = Console.ReadLine();
        Console.WriteLine("Release year");
        int newReleaseYear = int.Parse(Console.ReadLine());

        gameCompanies.Add(new GameCompany
        {
            Name = newName,
            YearOfFoundation = newYearOfFoundation,
            Game = new Game { GameName = newGameName, ReleaseYear = newReleaseYear }
        });

        string newFileName = "/Users/admin/EducationalProject/EducationalProject/gameCompanyName_updated.json";
        gameCompanySerializer.Serialize(gameCompanies, newFileName);

    }
}

