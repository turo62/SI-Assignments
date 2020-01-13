using System;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "Szia!");
            ThreadPool.QueueUserWorkItem(callback, "Hi!");
            ThreadPool.QueueUserWorkItem(callback, "Hello!");
            ThreadPool.QueueUserWorkItem(callback, "Ciao!");
            Console.ReadKey();
        }

        public static void ShowMyText(Object state)
        {
            string txt = "State: " + (string)state;
            txt += "Thread: " + Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine(txt);
        }
    }
}
