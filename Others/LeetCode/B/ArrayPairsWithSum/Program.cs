using System;
using System.Collections.Generic;

namespace ArrayPairsWithSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] { 10, 12, 15, -1, 7, 6, 5, 4, 2, 1 };
            int k = 11;

            var result = FindPairsWithSum(arr, k);
          
                Console.WriteLine(result);

            var result1 = FindPairsWithSum1(arr, k);

            Console.WriteLine(result1);


            Console.ReadKey();

        }

        public static int FindPairsWithSum(int[] nums, int k)
        {
            int count = 0;
            nums = new int[] { 1, 2, 5, 5, 10, 8, 2 };
            k = 10;

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = k - nums[i];
                if (!set.Contains(diff))
                    set.Add(nums[i]);
                else
                {
                    count++;
                }
            }

            return count;
        }

        public static int FindPairsWithSum1(int[] nums, int k)
        {
            Array.Sort(nums);

            int i = 0;
            int j = nums.Length - 1;
            int count = 0;
            while (i < j)
            {
                if (nums[i] + nums[j] == k)
                {
                    count++;i++;j--;
                }
                else if(nums[i] + nums[j] > k)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return count;

        }

    }
}
