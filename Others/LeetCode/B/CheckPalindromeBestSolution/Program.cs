using System;
using System.Globalization;

namespace CheckPalindromeBestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(IsPalindrome("kanaka"));

            Console.WriteLine(IsPalindrome2("A man, a plan, a canal: Panama"));
            Console.ReadLine();
        }

        public static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++,j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                
            }
            return true;
        }

        public static bool IsPalindrome2(string s)
        {
            s = s.ToLower();
            int i = 0; int j = s.Length - 1;
            while (i < j)
            {
                if (!char.IsLetterOrDigit(s[i]))
                { i++; continue; }
                else if (!char.IsLetterOrDigit(s[j]))
                { j--; continue; }
                else if (s[i] != s[j])
                    return false;

                i++;j--;
            }
            return true;
        }
    }
}
