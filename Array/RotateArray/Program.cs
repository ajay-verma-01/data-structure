using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 }; int k = 3;
            Solution.Rotate(nums, k);
            Solution.rightRotate(nums, k);
        }
    }

    public class Solution
    {
        public static void Rotate(int[] nums, int k)
        {

            if (nums.Length < k)
            {
                for (int i = 0; i < k; i++)
                {
                    int temp = nums[nums.Length - 1];
                    for (int j = nums.Length - 1; j > 0; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    nums[0] = temp;
                }
            }
            else
            {

                int n = nums.Length;
                if (n < 2)
                    return;
                int[] temp = new int[k];
                for (int i = 0; i < k; i++)
                {
                    temp[i] = nums[n - k + i];
                }

                for (int i = n - k - 1; i >= 0; i--)
                {
                    nums[i + k] = nums[i];
                }

                for (int i = 0; i < k; i++)
                {
                    nums[i] = temp[i];
                }

            }

        }


        public static void swap(int[] A, int i, int j)
        {
            int data = A[i];
            A[i] = A[j];
            A[j] = data;
        }

        public static void reverse(int[] A, int low, int high)
        {
            for (int i = low, j = high; i < j; i++, j--)
            {
                swap(A, i, j);
            }
        }

        public static void rightRotate(int[] nums, int k)
        {
            int n = nums.Length;
            // Reverse the last 'k' elements
            reverse(nums, n - k, n - 1);

            // Reverse the first 'n-k' elements
            reverse(nums, 0, n - k - 1);

            // Reverse the whole array
            reverse(nums, 0, n - 1);
        }

        

    }
}
