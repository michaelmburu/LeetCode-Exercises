using System;
namespace LeetCode50Exercises
{
    public class SortArrayToBST
    {
        /*
         * Given an array sorted in ascending order, convert it to a height in balanced BST
        */
        public TreeNode SortArrayToBST(int[] num)
        {
            return sortedArrayToBST(num, 0, num.Length - 1);
        }

        private TreeNode sortedArrayToBST(int[] arr, int start, int end)
        {
            if (start > end) return null;
            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(arr[mid]);
            node.left = sortedArrayToBST(arr, start, mid - 1);
            node.right = sortedArrayToBST(arr, mid + 1, end);
            return node;
        }
    }
}

