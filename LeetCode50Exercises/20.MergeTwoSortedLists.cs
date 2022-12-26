using System;
namespace LeetCode50Exercises
{
    public class MergeTwoLists
    {
        /*
         * 
        */
        public LinkedListNode<int> mergeTwoLists(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            LinkedListNode<int> dummyHead = new LinkedListNode<int>(0);
            LinkedListNode<int> p = dummyHead;
            while(l1 != null && l2 != null)
            {
                if(l1.Value < l2.Value)
                {
                    p.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    p.Next = l2;
                    l2 = l2.Next;
                }

                p = p.Next;
            }
            if (l1 != null) p.Next = l1;
            if (l2 != null) p.Next = l2;
            return dummyHead.Next;
        }
    }
}

