using System;

namespace IfANumberIsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(IsPalindrome(1221));
            Console.WriteLine(IsPalindrome(123321));

            Console.ReadLine();
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            if (x < 10)
                return true;

            int result = 0;
            int temp = x;
            while (temp != 0)
            {
                result = result * 10 + temp % 10;
                temp = temp / 10;
            }

            return result == x;
        }
    }
}
