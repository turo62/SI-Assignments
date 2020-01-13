using System;
using System.Threading;

namespace SimpleThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);

            first.Start();
            second.Start();

            first.Join();
            second.Join();

            Console.Read();

            static void Counting()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Count: {0} - ThreadID: {1}", i, Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(500);

                }
            }
        }
    }
}
