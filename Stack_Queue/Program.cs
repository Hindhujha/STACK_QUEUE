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
            Stack<int> stack =new Stack<int>();
            //pushing values into stack
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            //peeking values in stack
            Console.WriteLine("PEEKING STACK:" + stack.Peek());
            stack.Pop();
            //After Removing elements from stack
            Console.WriteLine(stack.Peek());

        }
    }
}
