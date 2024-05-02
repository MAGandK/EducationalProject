namespace Lesson13
{
    public class Mug 
	{
        private int capacity;

        public string Material {get; set;}

        public int Capacity
        {
            get => capacity;

            set
            {
                if (value <= 1)
                {
                    throw new MugExсeption("There is no such volume...", value);
                }
                else
                {
                    capacity = value;
                }
             }
        }

        public Mug(string material, int capacity)
		{
			Material = material;
			Capacity = capacity;
		}

        public void Display()
        {
            Console.WriteLine($"Mug details: {Material}, {Capacity}");
        }
    }
}