using System;
using System.Collections.Generic;

namespace FindDuplicateNumberInRange
{
    class Program
    {
        /*
         Given an array of n elements which contains elements from 0 to n-1, 
        with any of these numbers appearing any number of times. 
        Find these repeating numbers in O(n) and using only constant memory space.
        Input : n = 7 and array[] = {1, 2, 3, 1, 3, 6, 6}
        Output: 1, 3, 6
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 3, 1, 3, 6, 6 };
            var result = Solution.FindDuplicate(array);
        }
    }

    public class Solution
    {
        public static IList<int> FindDuplicate(int[] nums)
        {
            List<int> duplicates = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i])] > 0)
                {
                    nums[Math.Abs(nums[i])] = -nums[Math.Abs(nums[i])];
                }
                else
                {
                    duplicates.Add(Math.Abs(nums[i]));
                }
            }

            return duplicates;
        }
    }
}
