using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;

namespace CustomeHashTable
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public string Key { get; set; }
        public T Value { get; set; }
    }
    public class MyHashtable<T>
    {
        private readonly Node<T>[]  _buckets;

        public MyHashtable(int size)
        {
            _buckets = new Node<T>[size];
        }

        public T Get(string key)
        {
            ValidateKey(key);

            var (_,node) = GetNodeByKey(key);
            if (node == null)
            {
                throw new ArgumentNullException(nameof(key), $"The key {key} is not found.");
            }
            return node.Value;
        }

        protected (Node<T> previous, Node<T> current) GetNodeByKey(string key)
        {
            int position = GetBucketByKey(key);
            Node<T> listNode = _buckets[position];
            Node<T> previous = null;

            while (listNode != null)
            {
                if (listNode.Key == key)
                    return (previous, listNode);

                previous = listNode;
                listNode = listNode.Next;
            }

            return (null, null);
        }

        public bool Remove(string key) {

            ValidateKey(key);

            int position = GetBucketByKey(key);

            var (prevoius, current) = GetNodeByKey(key);

            if (current == null) return false;

            if (prevoius == null)
            {
                _buckets[position] = null;
                return true;
            }

            prevoius.Next = current.Next;
            return true;


        }

        public bool ConstainsKey(string key)
        {
            ValidateKey(key);

            var (_, node) = GetNodeByKey(key);
            return node != null;
        }

        public void Add(string key, T item) {

            ValidateKey(key);

            var valueNode = new Node<T> { Key = key, Value = item, Next = null };
            int position = GetBucketByKey(key);
            Node<T> listNode = _buckets[position];

            if (listNode == null)
            {
                _buckets[position] = valueNode;
            }
            else {
                while (listNode.Next != null)
                {
                    listNode = listNode.Next;

                }
                listNode.Next = valueNode;
            }

        }

        public int GetBucketByKey(string key)
        {
            var position = key[0] % _buckets.Length;
            return position;
            //var h = key.GetHashCode();
            //var v = key.GetHashCode() % _buckets.Length;
            //return Math.Abs(key.GetHashCode() % _buckets.Length);
        }

        protected void ValidateKey(string key) {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
        }
    }
}
