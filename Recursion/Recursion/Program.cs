using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Factorial Recursive of 5");
            Console.WriteLine(FactorialRecursive(5));

            Console.WriteLine("Factorial Recursive of 6");
            Console.WriteLine(FactorialRecursive(6));

            Console.WriteLine("Factorial Iterative of 5");
            Console.WriteLine(FactorialIterative(5));

            Console.WriteLine("Factorial Iterative of 6");
            Console.WriteLine(FactorialIterative(6));

            Console.WriteLine("FFibonacciRecursive  of 6");
            Console.WriteLine(FFibonacciRecursive(6));

            Console.WriteLine("FFibonacciRecursive  of 9");
            Console.WriteLine(FFibonacciRecursive(9));

            Console.WriteLine("FibonacciIterative of 6");
            Console.WriteLine(FibonacciIterative(6));

            Console.WriteLine("FFibonacciFibonacciIterative of 9");
            Console.WriteLine(FibonacciIterative(9));

            Console.WriteLine("ReverseString AJAYVERMA");
            Console.WriteLine(ReverseString("AJAYVERMA"));

            Console.WriteLine("ReverseString abcd");
            Console.WriteLine(ReverseString("abcd"));
        }

        public static int FactorialRecursive(int n)
        {
            if (n == 1)
                return 1;

            return n * FactorialRecursive(n - 1);
        }

        public static int FactorialIterative(int n)
        {
            var result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }

        public static int FFibonacciRecursive(int n)
        {
            if (n < 2)
                return n;
           
            return FFibonacciRecursive(n - 1) + FFibonacciRecursive(n - 2);

        }

        public static int FibonacciIterative(int n)
        {
            int[] array = new int[n +1];
            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[n];
        }

        public static string ReverseString(string s)
        {

            if (s.Length == 1)
                return s[0].ToString();

            return ReverseString(s.Substring(1)) + s[0];
        }
    }
}
