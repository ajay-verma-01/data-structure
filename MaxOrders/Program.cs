using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = filledOrders(new List<int>() { 2, 21, 24 }, 83178701);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int filledOrders(List<int> order, int k)
        {
            var orders = 0;
            var max = order.Max();
            while (max <= k && order.Count > 0)
            {
                if (max == k)
                {
                    
                    orders++;
                    return orders;
                }
                else if (k > max)
                {
                    k = k - max;
                    orders++;
                    order.Remove(max);
                    if(order.Count > 0)
                        max = order.Max();

                }

            }


            return orders;
        }
    }
}
