using System;
using System.Linq;

namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

            Example 1:

            Input:[3,0,1]
            Output: 2
            Example 2:

            Input:[9,6,4,2,3,5,7,0,1]
            Output: 8*/
        }
    }

    public class Solution
    {
        public int MissingNumber(int[] nums)
        {

            int max = nums.Max();
            if (max < nums.Length)
                return max + 1;

            int total = (max - 1 + 1) * (max - 1 + 2) / 2;

            for (int i = 0; i < nums.Length; i++)
            {
                total -= nums[i];
            }

            return total;


        }
    }
}
