using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STACK AND QUEUE PROBLEMS");
            //STACK
            Stack<int> stack =new Stack<int>();
            //pushing values into stack
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            //peeking values in stack
            Console.WriteLine(stack.Peek());
            stack.Pop();
            //After Removing elements from stack
            Console.WriteLine(stack.Peek());

            //QUEUE
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine(queue.Peek());

        }
    }
}
