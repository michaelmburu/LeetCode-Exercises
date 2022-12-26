using System;
namespace LeetCode50Exercises
{
    public class SwapNodePairs
    {
        public swapPairs(LinkedListNode<int> head)
        {
            LinkedListNode<int> dummy = new LinkedListNode<int>(0);

            dummy.Next = head;
            LinkedListNode<int> p = head;
            LinkedListNode<int> prev = dummy;
            while(p != null && p.Next != null)
            {
                LinkedListNode<int> q = p.Next, r = p.Next.Next;
                prev.Next = q;
                q.Next = p;
                p.Next = r;
                prev = p;
                p = r;
            }

            return dummy.Next;
        }
    }
}

