namespace Lesson21.Practice;

	public static class Array
    {
        public static void FillArray()
        {
            int rows = 5;
            int cols = 5;

            int[,] myArray = new int[rows, cols];

            var myRand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    myArray[i, j] = myRand.Next(0, 100);
                }
            }

            DisplayArray(myArray);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j > i)
                    {
                        myArray[i, j] = 1;
                    }
                }
            }

            DisplayArray(myArray);
        }

        public static void DisplayArray(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\n\n\n");
        }

    }

    

