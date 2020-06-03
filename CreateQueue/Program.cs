using System;
// This code is generated in order to understand queue's. This was a technical discussion with mentors.
namespace CreateQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Queue
    {
        private const int qSize = 10;
        private object[] qData;
        // Head and tail fields keep track of where to insert an item into the array and where to retrieve an item from the array
        private int qHead = 0, qTail = 0;
        // Indicates how many items are in the array
        private int qCount = 0;
        public Queue()
        {
            this.qData = new object[qSize];
        }
        public Queue(int size)
        {
            if (size > 0)
            {
                this.qData = new object[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            }
        }
        public void Enqueue(object item)
        {
            if (this.qCount == this.qData.Length)
            {
                throw new Exception("Queue is full");
            }
            this.qData[this.qHead] = item;
            this.qHead++;
            this.qHead %= this.qData.Length;
            this.qCount++;
        }
        public object Dequeue()
        {
            if (this.qCount == 0)
            {
                throw new Exception("Queue empty");
            }
            object queueItem = this.qData[this.qTail];
            this.qTail++;
            this.qTail %= this.qData.Length;
            this.qCount--;
            return queueItem;
        }
    }
}
