using System;
namespace LeetCode50Exercises
{
    public class MinimumDepth
    {
        /*
         * Given a binary tree find its min depth/length
         * Min depth is the no of nodes along the shortes
        */
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null) return MinDepth(root.right) + 1;
            if (root.right == null) return MinDepth(root.left) + 1;

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}

