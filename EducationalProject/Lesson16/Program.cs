using Lesson16.HomeWork;

namespace Lesson16;

class Program
{
    static void Main(string[] args)
    {
        //Library.Initialize();
        //Library.GetBooksByAuthor("Tolkien");
        //Library.GetBookCount();
        //Library.GetBooksFilteredByYear(2000);

        Game.Initialize();
        Game.GetCharacterWithHighestExperience();
        Game.GetAverageLevelOfEachSquad();
        Game.GetPercentageOfEachSquad();
        Game.GetSummHealthOfEachLevel();
        Game.GetSquadWithHighestAverageHealth();
    }
}

