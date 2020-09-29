using System;
using System.Collections.Generic;

namespace FindMissingNumbers
{
    class Program
    {
        /*Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), 
         * some elements appear twice and others appear once.

        Find all the elements of [1, n] inclusive that do not appear in this array.

        Could you do it without extra space and in O(n) runtime? Y
        ou may assume the returned list does not count as extra space.
        
         Example:

        Input:
        [4,3,2,7,8,2,3,1]

        Output:
        [5,6]
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[] { 4, 3, 2, 7, 8, 2, 3, 1};
            Solution.PrintMissingNumbers(a);
        }
    }

    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var list = new List<int>();

            int[] reg = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (reg[nums[i] - 1] == 0)
                {
                    reg[nums[i] - 1] = 1;
                }


            }

            for (int i = 0; i < reg.Length; i++)
            {

                if (reg[i] == 0)
                {
                    list.Add(i + 1);
                    Console.WriteLine(i + 1);
                }

            }

            return list;
        }

        public static IList<int> PrintMissingNumbers(int[] array)
        {
            var list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int value = Math.Abs(array[i]);
                if (array[value - 1] > 0)
                {
                    array[value - 1] = -array[value - 1];
                }
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > 0)
                {
                    list.Add(i + 1);
                    Console.WriteLine(i + 1);
                }
            }

            return list;
        }

    }
}
