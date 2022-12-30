using System;
namespace LeetCode50Exercises
{
    public class MinStack
    {
        /*
         * Design a stack that supports push, pop and retrieving the minimum
         * element in constant time.
        */

        private Stack<int> stack = new Stack<int>();
        private Stack<int> minStack = new Stack<int>();

        public void push(int x)
        {
            stack.Push(x);
            if(minStack.Count() < 0 || x <= minStack.Peek())
            {
                minStack.Push(x);
            }
        }

        public void pop()
        {
            if (stack.Pop().Equals(minStack.Peek())) minStack.Pop();
        }

        public int top()
        {
            return stack.Peek();
        }


        public int getMin()
        {
            return minStack.Peek();
        }
    }
}

