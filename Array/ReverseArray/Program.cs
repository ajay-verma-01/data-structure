using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
            Solution.ReverseString(s);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Solution
    {
        public static void ReverseString(int[] s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

        }
    }
}
