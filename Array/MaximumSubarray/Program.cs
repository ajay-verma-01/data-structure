using System;

namespace MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        //Input:[-2,1,-3,4,-1,2,1,-5,4],
        //Output: 6
        //Explanation:[4,-1,2,1] has the largest sum = 6.
        }

        public class Solution
        {
            public static int MaxSubArray(int[] a)
            {
                int size = a.Length;
                int max_so_far = int.MinValue,
                    max_ending_here = 0;

                for (int i = 0; i < size; i++)
                {
                    max_ending_here = max_ending_here + a[i];

                    if (max_so_far < max_ending_here)
                        max_so_far = max_ending_here;

                    if (max_ending_here < 0)
                        max_ending_here = 0;
                }

                return max_so_far;

                /*int max_so_far = a[0]; 
                int curr_max = a[0]; 

                for (int i = 1; i < size; i++) 
                { 
                    curr_max = Math.Max(a[i], curr_max+a[i]); 
                    max_so_far = Math.Max(max_so_far, curr_max); 
                } 

                return max_so_far; 
                */
            }
        }
    }
}
