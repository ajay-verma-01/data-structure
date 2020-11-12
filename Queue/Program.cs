using Queue;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BlockingQueue<int> queue = new BlockingQueue<int>(5);
            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    queue.Enqueue(i);
                }
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(queue.Dequeue());
                }
            });

            Console.ReadKey();
        }
    }
}
