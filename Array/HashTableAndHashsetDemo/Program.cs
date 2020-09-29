using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTableAndHashsetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //doesnt maintain order.
            Hashtable htable = new Hashtable();
            htable.Add("ajay", "ajay verma");
            htable.Add("main", "main data");
            htable.Add("array", "array data");
            htable.Add("ajay1", "ajay verma");
            htable.Add("dd", null);
            

            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine($"key: {item.Key}, value:{item.Value}");
            }

            //miantains order
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("ajay", "ajay verma");
            dic.Add("main", "main data");
            dic.Add("array", "array data");
            dic.Add("ajay1", "ajay verma");
            dic.Add("dd", null);

            foreach (var item in dic)
            {
                Console.WriteLine($"key: {item.Key}, value:{item.Value}");
            }


            HashSet<string> hset = new HashSet<string>();
            hset.Add("ajay");
            hset.Add("main");
            hset.Add("array");
            hset.Add("verma");
            hset.Add("dd");
            hset.Add(null);
            hset.Add(null);
            hset.Add("dd");

            foreach (var item in hset)
            {
                Console.WriteLine($"key: {item}");

            }
        }
    }
}
