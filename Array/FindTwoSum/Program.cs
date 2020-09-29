using System;
using System.Collections;
using System.Collections.Generic;

namespace FindTwoSum
{
    /*
     Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 2, 4, 6, 7, 8, 10, 13 };
            int sum = 9;

            //int[] a2 = FindTwoSum2(a1, sum);
            //for (int i = 0; i < a2.Length; i++)
            //{
            //    Console.Write(a2[i] + "  ");
            //}
            FindTwoSum3(a1, sum);
        }

        private static int[] FindTwoSum1(int[] a1, int sum)
        {
            int[] a2 = new int[2];

            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a1.Length; j++)
                {
                    if (i != j)
                    {
                        if (a1[i] + a1[j] == sum)
                        {
                            Console.WriteLine($"index {i} and {j}");
                            a2[0] = i;
                            a2[1] = j;
                        }
                    }
                }
            }

            return a2;
        }

        private static int[] FindTwoSum2(int[] a1, int sum)
        {
            //int[] a1 = new int[] { 2, 4, 6, 7, 8, 10, 13 };

            int[] a2 = new int[2];
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < a1.Length; i++)
            {
                var dif = sum - a1[i];
                if (!set.Contains(dif))
                {
                    set.Add(a1[i]);
                }
                else
                {
                    Console.WriteLine($"{dif} and {a1[i]}");
                }
            }

            return a2;
        }

        private static void FindTwoSum3(int[] a1, int sum)
        {
            //int[] a1 = new int[] { 2, 4, 6, 7, 8, 10, 13 };


            Array.Sort(a1);
            var i = 0;
            var j = a1.Length - 1;

            while (i < j)
            {
                if (a1[i] + a1[j] == sum)
                {
                    Console.WriteLine($"{a1[i]}, {a1[j]}");
                    i++;j--;
                }
                else if (a1[i] + a1[j] > sum)
                {
                    j--;
                }
                else
                {
                    i--;
                }
            }

        }
    }
}
