namespace FinalTest
{
    public static class Array
    {
        public static void FillArray()
        {
            int rows = 5;
            int cols = 5;

            string[,] myArray = new string[rows, cols];

            var myRand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    myArray[i, j] = ((char)myRand.Next('A', 'Z' + 1)).ToString();
                }
            }

            Console.WriteLine("Array before modification:");

            PrintArray(myArray);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i + j >= cols)
                    {
                        myArray[i, j] = "X";
                    }
                }
            }

            Console.WriteLine("Array after modification:");
            PrintArray(myArray);
        }

        static void PrintArray(string[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

