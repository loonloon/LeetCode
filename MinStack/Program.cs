using System.Collections.Generic;
/*
 * 155. Min Stack
 * https://leetcode.com/problems/min-stack/
 */
namespace MinStack
{
    class Program
    {
        /*
         * Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
         * push(x) -- Push element x onto stack.
         * pop() -- Removes the element on top of the stack.
         * top() -- Get the top element.
         * getMin() -- Retrieve the minimum element in the stack.
         *
         * Example:
         * MinStack minStack = new MinStack();
         * minStack.push(-2);
         * minStack.push(0);
         * minStack.push(-3);
         * minStack.getMin();   --> Returns -3.
         * minStack.pop();
         * minStack.top();      --> Returns 0.
         * minStack.getMin();   --> Returns -2.
         *
         */
        static void Main(string[] args)
        {
            var minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.Pop();
            minStack.Pop();
            minStack.Pop();
        }
    }

    public class MinStack
    {
        private readonly Stack<int> _stack;
        private readonly Stack<int> _minStack;

        /** initialize your data structure here. */
        public MinStack()
        {
            _stack = new Stack<int>();
            _minStack = new Stack<int>();
            _minStack.Push(int.MaxValue);
        }

        public void Push(int x)
        {
            _stack.Push(x);

            if (x <= _minStack.Peek())
            {
                _minStack.Push(x);
            }
        }

        public void Pop()
        {
            var temp = _stack.Pop();

            if (temp == _minStack.Peek())
            {
                _minStack.Pop();
            }
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _minStack.Peek();
        }
    }
}
