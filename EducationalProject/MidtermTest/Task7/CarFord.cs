namespace MidtermTest.Task7
{
	public class CarFord : CarBace
	{
		private string _carColor;

		private bool IsSportCar;


		public CarFord(string carModel, int carEngineCapacity, string carColor,
			bool isSportCar) : base(carModel, carEngineCapacity) 
		{
			_carColor = carModel;
			IsSportCar = isSportCar;
		}

        public override void ShowInfo()
        {
            base.ShowInfo();
			Console.WriteLine($"Color car: {_carColor}, Sportcar: {IsSportCar}");
        }
    }
}