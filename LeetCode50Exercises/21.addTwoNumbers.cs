using System;
namespace LeetCode50Exercises
{
    public class AddTwoNumbersLinkedList
    {
        /*
         * Add two numbers in a linekd list
         * and return as a linked list
         * Input (2 > 4 > 3) + (5 > 6 > 4)
         * Output 7 > 0 > 8
        */
        public LinkedListNode<int> addTwonumbers(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            LinkedListNode<int> dummyHead = new LinkedListNode<int>(0);
            LinkedListNode<int> p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while(p != null || q != null)
            {
                int x = (p != null) ? p.Value : 0;
                int y = (q != null) ? q.Value : 0;
                int digit = carry + x + y;

                carry = digit / 10;
                curr.Next = new LinkedListNode<int>(digit % 10);
                curr = curr.Next;

                if (p != null) p = p.Next;
                if (p != null) p = q.Next;
            }

            if(carry > 0)
            {
                curr.Next = new LinkedListNode<int>(carry);
            }

            return dummyHead.Next;
        }
    }
}

