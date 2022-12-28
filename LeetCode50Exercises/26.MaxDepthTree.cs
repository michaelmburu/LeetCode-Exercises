using System;
namespace LeetCode50Exercises
{
    public class MaxDepth
    {
        /*
         * Given a binary tree find it's maximum depth
         * MAximum depth is the number of nodes on the longest path from root node
         * to the furthest leaf node
        */
        public int isMaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(isMaxDepth(root.left), isMaxDepth(root.right) + 1);
        }
    }
}

