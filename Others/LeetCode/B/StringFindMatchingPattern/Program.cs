using System;
using System.Collections.Generic;
using System.Linq;

namespace StringFindMatchingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(WordPattern("abba", "dog cat cat dog"));

            Console.WriteLine(WordPattern2("abba", "dogcatcatdog"));
            Console.ReadKey();
        }

        public static bool WordPattern(string pattern, string s)
        {
            var words = s.Split(' ');

            if (pattern.Length != words.Length)
                return false;

            Dictionary<char, string> dic = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (dic.ContainsKey(pattern[i]))
                {
                    if (dic[pattern[i]] != words[i])
                        return false;
                }
                else if (dic.ContainsValue(words[i]))
                    return false;
                else
                    dic.Add(pattern[i], words[i]);
            }

            return true;
        }

        public static bool WordPattern2(string pattern, string s)
        {
            if (s.Length % pattern.Length != 0)
                return false;

            var size = s.Length / pattern.Length;


            var words = Split(s, size);

            if (pattern.Length != words.Length)
                return false;

            Dictionary<char, string> dic = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (dic.ContainsKey(pattern[i]))
                {
                    if (dic[pattern[i]] != words[i])
                        return false;
                }
                else if (dic.ContainsValue(words[i]))
                    return false;
                else
                    dic.Add(pattern[i], words[i]);
            }

            return true;
        }

        public static string[] Split(string s, int size)
        {
            return Enumerable.Range(0, s.Length / size).Select(i => s.Substring(i * size, size)).ToArray();
        }
    }
}
