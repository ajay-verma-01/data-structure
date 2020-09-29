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

        public static int[] MergeSortedArray(int[] a1, int[] a2)
        {
            int i = 0, j = 0, k = 0;
            int[] a3 = new int[a1.Length + a2.Length];

            while (i < a1.Length && j < a2.Length)
            {
              
                if (a1[i] < a2[j])
                    a3[k++] = a1[i++];
                else
                    a3[k++] = a2[j++];
            }

            while (i < a1.Length)
                a3[k++] = a1[i++];

            while (j < a2.Length)
                a3[k++] = a2[j++];

            

            return a3;
        }
    }
}
