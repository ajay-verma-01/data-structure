using System;
using System.Collections.Generic;
using System.Linq;

namespace FindCommonInTwoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            var result1 = Intersection1(nums1, nums2);

            for (int i = 0; i < result1.Length; i++)
            {
                Console.WriteLine(result1[i]);
            }

            var result2 = Intersection2(nums1, nums2);

            for (int i = 0; i < result2.Length; i++)
            {
                Console.WriteLine(result2[i]);
            }

            int[] nums3 = new int[] { 1,2,3,4,5,6,7,8 };
            int[] nums4 = new int[] { 3, 8, 15 };

            var result3 = Intersection3(nums3, nums4);

            for (int i = 0; i < result3.Length; i++)
            {
                Console.WriteLine(result3[i]);
            }
            Console.ReadKey();
        }

        public static int[] Intersection1(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray(); ;
        }

        public static int[] Intersection2(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            List<int> result = new List<int>();

         

            for (int i = 0; i < nums2.Length; i++)
            {
                if (set1.Contains(nums2[i]))
                    result.Add(nums2[i]);
            }

            return result.ToArray();
        }

        public static int[] Intersection3(int[] nums3, int[] nums4)
        {
            int[] result = new int[nums3.Length < nums4.Length ? nums3.Length : nums4.Length];
            int count = 0;
            for (int i = 0, j=0; i < nums3.Length && j< nums4.Length;)
            {
                if (nums3[i] < nums4[j])
                {
                    i++;
                }
                else if (nums3[i] > nums4[j])
                {
                    j++;
                }
                else
                {
                    result[count++] = nums3[i];
                    i++;
                    j++;
                }
            }

            Array.Resize(ref result, count);
            return result;
        }
    }
}
