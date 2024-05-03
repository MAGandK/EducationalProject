namespace MidtermTest.Task7
{
    public class CarAudi : CarBace
    {
        private int _numberDoors;

        public CarAudi(string carModel, int carEngineCapacity, int numberDoors) : base(carModel, carEngineCapacity)
        {
            _numberDoors = numberDoors;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Number of doors: {_numberDoors}");
        }
    }
}