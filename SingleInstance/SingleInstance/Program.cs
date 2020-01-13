using System;
using System.Threading;

namespace SingleInstance
{
    class Program
    {
        static string mutexName = "RUNMEONLYONCE";
        static void Main(string[] args)
        {
            Mutex mutex = null;
            while (true)
            {
                try
                {
                    mutex = Mutex.OpenExisting(mutexName);
                    Console.WriteLine("Mutex found, exiting..");
                    mutex.Close();
                    break;
                }
                catch (WaitHandleCannotBeOpenedException)
                {
                    mutex = CreateNewM();
                }
            }
            Console.ReadKey();
        }

        static Mutex CreateNewM()
        {
            bool mine = true;
            Console.WriteLine("Mutex not found, created.");
            return new Mutex(mine, mutexName);
        }
    }
}
