using System;

namespace MoveZeroToTheEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 0, 0,1, 0, 3, 12 };
            Solution.MoveZeroes(nums);
        }

        public class Solution
        {
            public static void MoveZeroes(int[] nums)
            {
                int n = nums.Length;
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (nums[i] != 0)
                    {
                        nums[count++] = nums[i];
                    }
                }

                for (int i = count; i < n; i++)
                {
                    nums[i] = 0;
                }
            }
        }
    }
}
