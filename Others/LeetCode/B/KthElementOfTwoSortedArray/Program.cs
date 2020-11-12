using System;
using System.Globalization;

namespace KthElementOfTwoSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] arr1 = new int[] { 2,3,6,7,9};
            //int[] arr2 = new int[] { 1,4,8,10 };
            int[] arr1 = new int[] { 1,2 };
            int[] arr2 = new int[] { 3,4 };


            var r = KthElement(arr1, arr2, 5);

            Console.WriteLine(r);
            Console.ReadKey();
        }

        public static int KthElement(int[] nums1, int[]nums2, int k)
        {
            int[] a3 = new int[nums1.Length + nums2.Length];
            int d = 0, i = 0, j = 0;
            for (i = 0, j=0 ; i < nums1.Length && j <nums2.Length;)
            {
                if (nums1[i] < nums2[j])
                {
                    a3[d] = nums1[i];
                    i++;d++;
                }
                else if(nums2[j] < nums1[i])
                {
                    a3[d] = nums2[j];
                    j++;d++;
                }
                else
                {
                    a3[d] = nums1[i];
                    j++;i++;d++;
                }
            }

            while (i < nums1.Length)
            {
                a3[d++] = nums1[i++];
            }

            while (j < nums2.Length)
            {
                a3[d++] = nums2[j++];
            }

            double r = 0;
            int n = (nums1.Length + nums2.Length) / 2;

            if ((nums1.Length + nums2.Length) % 2 !=0)
                r = a3[n];
            else
                r = (double) (a3[n - 1] + a3[n]) / 2;

                

            //return a3;

            return a3[k-1];

          

        }
    }
}
