using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayCustome
{
    public class MyArray
    {
        public int length;
        public int[] data;

        public MyArray()
        {
            length = 0;
            data = new int[0];
        }

        public int get(int index)
        {
            return data[index];
        }

        public int push(int item)
        {
            length++;
            resizeArray(ref data, length);
            data[length - 1] = item;
            return length - 1;
        }

        public int pop()
        {
            var lastItem = data[length - 1];
            resizeArray(ref data, length - 1);
            length--;
            return lastItem;

        }

        public int deleteAtIndex(int index)
        {
            var item = data[index];
            int[] temp = new int[length - 1];
            for (int i = 0; i < length; i++)
            {
                if (index > i)
                {
                    temp[i] = data[i];
                }
                if (index < i)
                {
                    temp[i - 1] = data[i];
                }
            }
            length--;
            data = new int[length];
            for (int i = 0; i < temp.Length; i++)
            {
                data[i] = temp[i];
            }

            return item;
        }
        private void resizeArray(ref int[] data, int newLength)
        {
            if (newLength < 1)
            {
                Console.WriteLine("oh that's not good.");
                return;
            }

            if (data == null)
            {
                data = new int[1];
            }
            else
            {
                int[] temp = new int[newLength];

                if (data.Length < newLength)
                {
                    for (int i = 0; i < newLength - 1; i++)
                    {
                        temp[i] = data[i];
                    }
                }
                else if (data.Length > newLength)
                {
                    for (int i = 0; i < newLength; i++)
                    {
                        temp[i] = data[i];
                    }
                }

                data = new int[newLength];
                for (int i = 0; i < temp.Length; i++)
                {
                    data[i] = temp[i];
                }
            }
        }
    }

}
