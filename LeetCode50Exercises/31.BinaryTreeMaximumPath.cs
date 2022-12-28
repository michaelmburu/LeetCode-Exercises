using System;
namespace LeetCode50Exercises
{
    public class BinaryTreeMaximumPath
    {
        /*
         * Given a binary tree, find the maximum path sum 
        */

        private int maxSum;

        public int findMax(TreeNode p)
        {
            if (p == null) return 0;
            int left = findMax(p.left);
            int right = findMax(p.right);
            maxSum = Math.Max(p.val + left + right, maxSum);
            int ret = p.val + Math.Max(left, right);
            return ret > 0 ? ret : 0;
        }
    }
}

