using System;
using System.Linq;
using System.Text;

namespace StringRemoveIdentical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = RemoveAdjacentDuplicate("aabbcdeegghiij");
            Console.WriteLine(result);

          

            var s2 = RemoveAdjacentDuplicate1("deeedbbcccbdaa", 3);
            Console.WriteLine(s2);
            Console.ReadKey();
        }

        public static string RemoveAdjacentDuplicate(string s)
        {
            char[] a = s.ToArray();
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[j] != a[i])
                {
                    a[++j] = a[i];
                }
            }

            return new string(a).Remove(j + 1);
        }

        public static string RemoveAdjacentDuplicate1(string s, int k)
        {
            //StringBuilder sb = new StringBuilder(s);
            //int i = 0;
            //int[] count = new int[sb.Length];
            //while (i < sb.Length)
            //{
            //    if (i == 0 || sb[i] != sb[i - 1])
            //    {
            //        count[i] = 1;
            //    }
            //    else
            //    {
            //        count[i] = count[i - 1] + 1;
            //        if(count[i] == k)
            //        {
            //            sb.Remove(i - k + 1, k);
            //            i = i - k;

            //        }
            //    }
            //    i++;
            //}

            //return sb.ToString();

            StringBuilder sb = new StringBuilder(s);

            int counter = 0;
            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (i < 0)
                    continue;
                if (i == 0 || sb[i] != sb[i - 1])
                {
                    counter = 1;
                }
                else
                {
                    counter++;
                    if (counter == k)
                    {
                        sb = sb.Remove(i - k + 1, k);
                        i = i - k -1;
                        counter = 1;
                    }
                }

              
            }

            return sb.ToString();
        }

        public static string RemoveAdjacent1(string s, int k)
        {
            StringBuilder sb = new StringBuilder(s);

            int counter = 1;
            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (i == 0)
                    if (i < 0)
                        i = 0;

                if (sb[i] == sb[i + 1])
                {
                    counter++;
                    if (counter == k)
                    {
                        sb = sb.Remove(i - k + 2, k);
                        i = i - k - 1;
                        counter = 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            return sb.ToString();
        }

    
    }
}
