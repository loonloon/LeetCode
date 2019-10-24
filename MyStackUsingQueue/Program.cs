using System.Collections.Generic;
/*
 * 225. Implement Stack using Queues
 * https://leetcode.com/problems/implement-stack-using-queues/
 */
namespace MyStackUsingQueue
{
    class Program
    {
        /*
         * Implement the following operations of a stack using queues.
         * push(x) -- Push element x onto stack.
         * pop() -- Removes the element on top of the stack.
         * top() -- Get the top element.
         * empty() -- Return whether the stack is empty.
         *
         * Example:
         * MyStack stack = new MyStack();
         * stack.push(1);
         * stack.push(2);
         * stack.top();   // returns 2
         * stack.pop();   // returns 2
         * stack.empty(); // returns false
         *
         * Notes:
         * You must use only standard operations of a queue -- which means only push to back, peek/pop from front, size,
         * and is empty operations are valid.
         *
         * Depending on your language, queue may not be supported natively.
         * You may simulate a queue by using a list or deque (double-ended queue), as long as you use only standard operations of a queue.
         *
         * You may assume that all operations are valid (for example, no pop or top operations will be called on an empty stack).
         *
         */
        static void Main(string[] args)
        {
            var obj = new MyStack();
            obj.Push(1);
            obj.Push(2);

            var param2 = obj.Top();
            var param3 = obj.Pop();
            var param4 = obj.Empty();
        }
    }

    public class MyStack
    {
        private readonly Queue<int> _queueFirst;
        private readonly Queue<int> _queueSecond;

        /** Initialize your data structure here. */
        public MyStack()
        {
            _queueFirst = new Queue<int>();
            _queueSecond = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            while (_queueFirst.Count > 0)
            {
                _queueSecond.Enqueue(_queueFirst.Dequeue());
            }

            _queueFirst.Enqueue(x);

            while (_queueSecond.Count > 0)
            {
                _queueFirst.Enqueue(_queueSecond.Dequeue());
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return _queueFirst.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return _queueFirst.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return _queueFirst.Count == 0;
        }
    }

}
