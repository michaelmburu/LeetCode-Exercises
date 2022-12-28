using System;
namespace LeetCode50Exercises
{
    public class CopyRandomListInNode
    {
        /*
         * Return a deep copy of the list with pointers
         * 
         * Solution clone a linked list 
        */
        public LinkedListNode<int> _RandomListNode(LinkedListNode<int> head)
        {
            Dictionary<LinkedListNode<int>, LinkedListNode<int>> map = new Dictionary<LinkedListNode<int>, LinkedListNode<int>>();
            LinkedListNode<int> p = head;
            LinkedListNode<int> dummy = new LinkedListNode<int>(0);
            LinkedListNode<int> q = dummy;

            while(p != null)
            {
                q.Value = new LinkedListNode<int>(p.Value);
                map.put(p, q.Next);
                p = p.Next;
                q = q.Next
            }
            p = head;
            q = dummy;
            while(p != null)
            {
                q.Next.random = map.GetValueOrDefault(p.Value);
                p = p.Next;
                q = q.Next;
            }

            return dummy.Next;
        }
    }
}

