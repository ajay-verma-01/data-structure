using System;
using System.Security.Cryptography;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a1 = new int[] { 1,11, 12,14};
            int[] a2 = new int[] { 2, 4, 6, 7, 8,10,13 };

            var a3 = MergeSortedArray(a1, a2);

            for (int i = 0; i < a3.Length; i++)
            {
                Console.WriteLine(a3[i]);
            }
        }

        public static int[] MergeSortedArray(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0, k = 0;
            int[] a3 = new int[nums1.Length + nums2.Length];

            while (i < nums1.Length && j < nums2.Length)
            {
              
                if (nums1[i] < nums2[j])
                    a3[k++] = nums1[i++];
                else
                    a3[k++] = nums2[j++];
            }

            while (i < nums1.Length)
                a3[k++] = nums1[i++];

            while (j < nums2.Length)
                a3[k++] = nums2[j++];


            return a3;
        
        }
    }
}
