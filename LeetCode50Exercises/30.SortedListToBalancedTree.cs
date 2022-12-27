using System;
namespace LeetCode50Exercises
{
    public class SortedListToBST
    {
        /*
         * Given a linked list where elements are sorted in ascending order.
         * Convert it to a height binary list
         * Solution create nodes bottom up.
        */

        private LinkedListNode<int> list;

        public SortListToBST()
        {
            private TreeNode sortListtoBST(int start, int end)
            {
                if (start > end) return null;
                int mid = (start + end) / 2;
                TreeNode leftChild = sortListtoBST(start, mid - 1);
                TreeNode parent = new TreeNode(list.val);
                parent.left = leftChild;
                list = list.Next;
                parent.right = sortedListtoBST(mid + 1, end);
                return parent;
            }

            private TreeNode sortedListBST(LinkedListNode<int> head)
            {
                int n = 0;
                LinkedListNode<int> p = head;
                while(p != null)
                {
                    p = p.Next;
                    n++;
                }

                list = head;
                return SortedListToBST(0, n - 1);
            }
        }
    }
}

