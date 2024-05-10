namespace Lesson16.HomeWork
{
	public class Character
	{
		public string Name { get; set; }

		public int Level { get; set; }

		public EnumCharacter Squad { get; set; }

		public int Experience { get; set; }

		public int Health { get; set; }

		public Character(string name, int level, EnumCharacter squad, int experience, int health )
		{
			Name = name;
			Level = level;
			Squad = squad;
			Experience = experience;
			Health = health;
		}

		public Character()
		{

		}
	}
}
