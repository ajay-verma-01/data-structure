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
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        var temp = nums[count];
                        nums[count] = nums[i];
                        nums[i] = temp;

                        count++;
                    }
                }
            }
        }
    }
}
