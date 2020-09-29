using System;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("my name is ajay kumar vermajay I am from Raipur");
            string s = "my name is ajay kumar vermajay I am from RaipurCHHGRH";

            Console.WriteLine(GetLongestWord(s));


        }

        public static string GetLongestWord(string s)
        {
            string longest = "";
            string longestHere = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    longestHere += s[i];
                }
                else
                {
                    if (longest.Length < longestHere.Length)
                    {
                        longest = longestHere;
                    }
                    longestHere = "";
                }
            }

            if (longest.Length < longestHere.Length)
            {
                longest = longestHere;
            }

            return longest;
        }
    }
}
