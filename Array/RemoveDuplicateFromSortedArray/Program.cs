using System;

namespace RemoveDuplicateFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[] { 4, 5, 5, 6, 7, 7, 8, 9, 10, 10, 11 };
            RemoveDeplicate(array);
        }

        public static void RemoveDeplicate(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length -1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            nums[j++] = nums[nums.Length - 1];
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
