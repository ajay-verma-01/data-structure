using System;

namespace FindAllPrimeNumbers1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FindAllPrime(100);

            Console.ReadKey();
        }

        public static void FindAllPrime(int n)
        {
            int i, j, flag;

            for (i = 2; i  <= n; i++)
            {
                flag = 1;
                for ( j = 2; j <= i/2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                    Console.WriteLine(i + " ");
            }
        }
    }
}
