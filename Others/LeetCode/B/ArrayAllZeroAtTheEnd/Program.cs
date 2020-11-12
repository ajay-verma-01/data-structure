using System;
using System.Globalization;

namespace ArrayAllZeroAtTheEnd
{
    /*
     Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
    
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var numbers = new int[] { 0,0,  1, 0, 3, 12 };
            MoveZeroes(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Single Iteration
        /// </summary>
        /// <param name="nums"></param>
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

            //while (count < nums.Length)
            //{
            //    nums[count++] = 0;
            //}

        }

        /// <summary>
        /// Two iteration
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes1(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[count++] = nums[i];
                }
            }

            while (count < nums.Length)
            {
                nums[count++] = 0;
            }

        }
    }
}
