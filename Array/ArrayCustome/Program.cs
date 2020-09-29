using ArrayCustome;
using System;


namespace CustomeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure!");

            int[] array1 = new[] { 1, 0, 3, 4, 5 };
            Array.Resize(ref array1, array1.Length + array1.Length);
            array1[array1.GetUpperBound(0)] = 6;

            for (int i = 0; i < array1.Length; i++)
            {
                //Console.WriteLine(array1[i]);
            }
            /////////////////////////////////Custome Array/////////////////////////
            Console.WriteLine("Custome Array");
            var array2 = new MyArray();
            array2.push(1);
            array2.push(2);
            array2.push(3);
            array2.push(4);
            array2.push(5);
            array2.push(6);
            array2.push(7);
            array2.push(8);
            array2.push(9);

            for (int i = 0; i < array2.length; i++)
            {
                Console.WriteLine(array2.data[i]);
            }

            Console.WriteLine("Indiex 2:");
            Console.WriteLine(array2.get(2));

            array2.pop();
            Console.WriteLine("After Pop:");
            for (int i = 0; i < array2.length; i++)
            {
                Console.WriteLine(array2.data[i]);
            }

            Console.WriteLine("After Delete index 2:");
            array2.deleteAtIndex(2);

            for (int i = 0; i < array2.length; i++)
            {
                Console.WriteLine(array2.data[i]);
            }

            ////////////////////////////////Custome Array/////////////////////////
            //Console.ReadKey();
        }
    }

    public static class ArrayExtension
    {
        public static int Push<T>(this T[] source, T value)
        {
            var index = Array.IndexOf(source, default(T));
            if (index != -1)
            {
                source[index] = value;
            }

            return index;
        }
    }
}
