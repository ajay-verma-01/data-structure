using System;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a1 = new int[] { 2, 4, 6, 7, 8, 2, 13 };
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            bool result = false;


            return result;
        }
    }

    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            /*
            HashSet<int> sets = new HashSet<int>();
            for(int i = 0; i< nums.Length; i++)
            {
                if(sets.Contains(nums[i]))
                    return true;
                else
                {
                    sets.Add(nums[i]);
                }

            }
            return false;
            */

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    return true;
            }

            return false;

        }
    }
}
