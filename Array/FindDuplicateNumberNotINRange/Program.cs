using System;
using System.Collections.Generic;

namespace FindDuplicateNumberNotINRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 3, 1, 3, 6, 6, 11, 25, 33, 33, 60, 60 };

            var dup = Solution.FindDuplicate(array);
        }
    }

    public class Solution
    {
        public static IList<int> FindDuplicate(int[] nums)
        {
            List<int> duplicates = new List<int>();
            HashSet<int> sets = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!sets.Contains(nums[i]))
                {
                    sets.Add(nums[i]);
                }
                else
                {
                    duplicates.Add(nums[i]);
                }
            }

            return duplicates;
        }
    }
}
