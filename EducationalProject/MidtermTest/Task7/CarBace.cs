namespace MidtermTest.Task7
{
	public class CarBace
	{
		private string _carModel;

		private int _carEngineCapacity;

		public CarBace(string carModel, int carEngineCapacity)
		{
			_carModel = carModel;
			_carEngineCapacity = carEngineCapacity;
		}

		public virtual void ShowInfo()
		{
			Console.WriteLine($"Car model:  {_carModel}");
			Console.WriteLine($"Car engine capacity: {_carEngineCapacity}");
		}
    }
}