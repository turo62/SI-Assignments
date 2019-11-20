using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            queue.Enqueue("fourth");

            while (queue.Count > 0)
            {
                Console.WriteLine("\nQueue size before removal: {0}", queue.Count);
                object o = queue.Dequeue();
                Console.WriteLine("Removed: {0}", o);
                Console.WriteLine("Queue size after removal: {0}", queue.Count);
            }

            Stack stack = new Stack();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            stack.Push("fourth");

            while (stack.Count > 0)
            {
                Console.WriteLine("\nStack size before removal: {0}", stack.Count);
                object o = stack.Pop();
                Console.WriteLine("Removed: {0}", o);
                Console.WriteLine("Stack size after removal: {0}", stack.Count);
            }


        }
    }
}
