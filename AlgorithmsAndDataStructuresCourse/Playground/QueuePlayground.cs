using System;
using AlgorithmsAndDataStructuresCourse.DataStructures;

namespace AlgorithmsAndDataStructuresCourse.Playground
{
    public static class QueuePlayground
    {
        public static void QueueTest1()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.queueLength);
            Console.WriteLine(queue.QueueContents());

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(queue.QueueContents());

            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.Enqueue(11);

            Console.WriteLine(queue.QueueContents());
        }
    }
}
