using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Fibonaci 8");
            Console.WriteLine(Fibonaci(8));
        }


        public static int Fibonaci(int n)
        {
            if (n < 2)
                return n;

            return Fibonaci(n - 1) + Fibonaci(n - 2);
        }

        public static int FibonaciDynamic(int n)
        {
            int[] cache = new int[n + 2];
            cache[0] = 0;
            cache[1] = 1;

            for (int i = 2; i <= n ; i++)
            {
                cache[i] = cache[i - 1] + cache[i - 2];
            }

            return cache[n];
        }

        // using Space Optimized Method 
        public static int FibSpaceOptimized(int n)
        {
            int a = 0, b = 1, c = 0;

            // To return the first Fibonacci number  
            if (n == 0) return a;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
