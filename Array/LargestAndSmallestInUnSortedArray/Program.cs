using System;

namespace LargestAndSmallestInUnSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[] { 3, 57, 3, 23, 56, 22, 67, 80 };
            FindLargestAndSmallest(a);
        }

        public static void FindLargestAndSmallest(int[] nums)
        {
            int largest = nums[0];
            int smallest = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (smallest > nums[i])
                {
                    smallest = nums[i];
                }
                if (largest < nums[i])
                {
                    largest = nums[i];
                }
            }

            Console.WriteLine($"smallest: {smallest}, largest= {largest}");
        }
    }


    

}
