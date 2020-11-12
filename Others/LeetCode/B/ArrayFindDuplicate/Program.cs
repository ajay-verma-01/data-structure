using System;
using System.Collections.Generic;

namespace ArrayFindDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = FindDuplicates1(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }

        public IList<int> FindDuplicates(int[] nums)
        {
            var hs = new HashSet<int>();
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hs.Contains(nums[i]))
                    hs.Add(nums[i]);
                else
                    list.Add(nums[i]);
            }

            return list;
        }

        public static IList<int> FindDuplicates1(int[] nums)
        {
            List<int> duplicates = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var k = Math.Abs(nums[i]) -1;

                if (nums[k] < 0)
                {
                    duplicates.Add(k+1);
                    
                }
                else
                {
                    nums[k] = -nums[k];
                }
            }

            return duplicates;
        }
    }
}
