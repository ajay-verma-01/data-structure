using System;

namespace Sortings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] ac = new char[] { 'd', 'b', 'a', 'c', 'e' };
            int[] ai = new int[] { 4, 2, 1, 3, 5 };
            Array.Sort(ac);

            Console.WriteLine("Default Sort string");

            for (int i = 0; i < ac.Length; i++)
            {
                Console.Write(ac[i] + "  ");
            }

            Array.Sort(ai);
            Console.WriteLine("\nDefault Sort Int");

            for (int i = 0; i < ai.Length; i++)
            {
                Console.Write(ai[i] + "  ");
            }


            ai = new int[] { 4, 2, 1, 3, 5 };
            Console.WriteLine("\nBubble Sort");
            BubleSort(ai);
            for (int i = 0; i < ai.Length; i++)
                Console.Write(ai[i] + "  ");

            ai = new int[] { 4, 2, 1, 3, 5 };
            Console.WriteLine("\nSelection Sort");
            SelectionSort(ai);
            for (int i = 0; i < ai.Length; i++)
                Console.Write(ai[i] + "  ");

            ai = new int[] { 4, 2, 1, 3, 5 };
            Console.WriteLine("\nInsertionSort Sort");
            InsertionSort(ai);
            for (int i = 0; i < ai.Length; i++)
                Console.Write(ai[i] + "  ");

            ai = new int[] { 4, 2, 1, 3, 5 };
            Console.WriteLine("\nMergeSort Sort");
            MergeSort(ai, 0, ai.Length -1);
            for (int i = 0; i < ai.Length; i++)
                Console.Write(ai[i] + "  ");

            ai = new int[] { 4, 2, 1, 3, 5 };
            Console.WriteLine("\nQuickSort Sort");
            QuickSort(ai, 0, ai.Length - 1);
            for (int i = 0; i < ai.Length; i++)
                Console.Write(ai[i] + "  ");
        }

        public static void BubleSort(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length -1; j++)
                {
                    if (n[j] > n[j+1])
                    {
                        int temp = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = temp;

                    }
                }
            }
        }

        public static void SelectionSort(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[minIndex] > n[j])
                        minIndex = j;
                }

                int temp = n[i];
                n[i] = n[minIndex];
                n[minIndex] = temp;
            }
        }

        public static void InsertionSort(int[] n)
        {
            for (int i = 1; i < n.Length; i++)
            {
                var key = n[i];
                var j = i - 1;

                while (j >= 0 && n[j] > key)
                {
                    n[j + 1] = n[j];
                    j = j - 1;
                }

                n[j + 1] = key; 
            }
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged 
            int n1 = m - l + 1;
            int n2 = r - m;

            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int i1 = 0; i1 < n1; ++i1)
            {
                L[i1] = arr[l + i1];
            }
            for (int j1 = 0; j1 < n2; ++j1)
            {
                R[j1] = arr[m + 1 + j1];
            }

            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays 
            int i = 0, j = 0;

            // Initial index of merged subarry array 
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point 
                int middle = (left + right) / 2;

                // Sort first and second halves 
                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                // Merge the sorted halves 
                Merge(input, left, middle, right);
            }
        }


        /* The main function that implements QuickSort() 
    arr[] --> Array to be sorted, 
    low --> Starting index, 
    high --> Ending index */
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        /* This function takes last element as pivot, 
    places the pivot element at its correct 
    position in sorted array, and places all 
    smaller (smaller than pivot) to left of 
    pivot and all greater elements to right 
    of pivot */
        private static int Partition(int[] arr, int low, int high)
        {
            int pi = arr[high];

            // index of smaller element 
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot
                if (arr[j] < pi)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
