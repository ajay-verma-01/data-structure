using System;

namespace StringFindMostPopulousChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(getMaxOccuringChar("AJAYKUMAR VERMA"));
        }

        public static char getMaxOccuringChar(String str)
        {
            int[] count = new int[256];

            for (int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;
            }

            int max = -1;
            char result = ' ';

            for (int i = 0; i < str.Length; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }

            return result;
        }
    }
}
