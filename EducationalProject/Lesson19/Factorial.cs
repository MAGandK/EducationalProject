namespace Lesson19
{
	public static class Factorial
	{
        public static void RunThread()
        {
            Thread[] threads = new Thread[10];

            for (int i = 1; i <= 10; i++)
            {
                int number = i;
                threads[i - 1] = new Thread(() => CalculateFactorial(number));
                threads[i - 1].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }
        }

        public static void RunThreadPool()
        {
            for (int i = 1; i < 10; i++)
            {
                int number = i;
                ThreadPool.QueueUserWorkItem(p => CalculateFactorial(number));
            }

            Thread.Sleep(5000);
        }

        public static void CalculateFactorial(int number)
        {
            int result = Get(number);

            Console.WriteLine($"Thread number: {number}, factorial this {number} = {result}");
        }

        public static int Get(int n)
        {
            if (n <= 1) return 1;
            return n * Get(n - 1);
        }
    }
}

