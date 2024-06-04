using System;
namespace Lesson22.Practice
{
	internal class Events
	{
		public event EventHandler MetodCallTen;


		public static int counter = 0;

		public void Test()
		{
			Console.WriteLine("Метод вызванcounter" + counter);


            counter++;

			if (counter >= 10)
			{
				OnTestCalledTen();
			}
		}

		public void OnTestCalledTen()
		{
			MetodCallTen?.Invoke(this, EventArgs.Empty); 
		}
	}
}

