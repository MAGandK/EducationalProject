using System;
namespace Lesson22
{
	public static class ArrayInt
	{
		private static void GetArray()
		{
			int[] myArray = new int[]{ -1, -2, -3, -4,-5};

			int avgMyArray = (int)myArray.Where(n => n < 0).Average();

			Console.WriteLine(avgMyArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < 0)
                {
                    myArray[i] = avgMyArray;
                }
            }

            foreach (var item in myArray)
            {
                Console.Write(item + "");
            }

        }
	}

}

