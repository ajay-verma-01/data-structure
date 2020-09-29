using System;

namespace CustomeHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var hashtable = new MyHashtable<int>(4);
            Console.WriteLine(hashtable.GetBucketByKey("One"));
            Console.WriteLine(hashtable.GetBucketByKey("Two"));
            Console.WriteLine(hashtable.GetBucketByKey("Three"));

            hashtable.Add("One", 1);
            hashtable.Add("Two", 2);
            hashtable.Add("Three", 3);
            hashtable.Add("Five", 5);
            hashtable.Add("Ten", 10);

            Console.WriteLine(hashtable.Get("One"));
            Console.WriteLine(hashtable.Get("Two"));
            Console.WriteLine(hashtable.Get("Three"));
            Console.WriteLine(hashtable.Get("Five"));
            Console.WriteLine(hashtable.Get("Ten"));

            try
            {
                Console.WriteLine(hashtable.Get("Four"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(hashtable.Remove("Three"));
            Console.WriteLine(hashtable.Remove("Three"));
            Console.WriteLine(hashtable.Remove("Two"));
            Console.WriteLine(hashtable.Remove("Two"));
        }
    }
}
