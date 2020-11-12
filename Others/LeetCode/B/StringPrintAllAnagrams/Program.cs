using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StringPrintAllAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(isAnagram("hello", "lolha"));
            Console.WriteLine(isAnagram2("hello", "lolhe"));
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var list = GroupAnagrams(strs);
            for (int i = 0; i < list.Count; i++)
            {
               
            }
            Console.ReadKey();
        }

        public static bool isAnagram(string c, string d)
        {
            int[] count1 = new int[256];
            for (int i = 0; i < c.Length; i++)
            {
                count1[c[i]]++;
            }

            int[] count2 = new int[256];
            for (int i = 0; i < d.Length; i++)
            {
                count2[d[i]]++;
            }

            for (int i = 0; i < 256; i++)
            {
                if (count1[i] != count2[i])
                    return false;
            }

            return true;
        }

        public static bool isAnagram2(string c, string d)
        {
            if (c.Length != d.Length)
                return false;

            int[] count = new int[256];
            for (int i = 0; i < c.Length; i++)
            {
                count[c[i]]++;
                count[c[i]]--;
            }

            for (int i = 0; i < 256; i++)
            {
                if (count[i] != 0)
                    return false;
            }

            return true;
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var str = new String(strs[i].OrderBy(s => s).ToArray());

                if (dic.ContainsKey(str))
                {
                    var list = dic[str];
                    list.Add(strs[i]);
                }
                else
                {
                    var list = new List<string>();
                    list.Add(strs[i]);
                    dic.Add(str, list);
                }

            }

            return dic.Values.ToList();
        }
    }
}
