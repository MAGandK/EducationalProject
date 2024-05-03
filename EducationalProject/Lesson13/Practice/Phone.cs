namespace Lesson13
{
	public class Phone 
	{
        private int price;
        private string model;

        public string Model
        {
            get => model;

            set
            {
                if (value?.Length <= 3)
                {
                    throw new PhoneExсeption("The model cannot be less than three characters...", value);
                }
                else
                {
                    model = value;
                }

            }
        }

        public int Price { get; set; }

        public Phone( string model, int price)
		{
            Model = model;
            Price = price;
		}

        public void Display()
        {
            Console.WriteLine($"Phone details: {Model}, {Price}");
        }
    }
}