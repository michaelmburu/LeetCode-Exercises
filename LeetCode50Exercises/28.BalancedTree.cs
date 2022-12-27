using System;
namespace LeetCode50Exercises
{
    public class BalancedTree
    {
        /*
         * Given a binary tree, determine if it is height balanced
         * Left nodes equal 
         * O(n2)
        */
        public bool IsBalancedTree(TreeNode root)
        {
            if (root == null) return true;
            return Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) <= 1
                && IsBalancedTree(root.left)
                && IsBalancedTree(root.right);
            //return MaxDepth(root) != 1;
        }

        public int MaxDepth(TreeNode root)
        {
            if (root = null) return 0 ;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }

        //O(n)
        private int MaxDepth(Treenode root)
        {
            if (root == null) return 0;
            int L = MaxDepth(root.left);
            if (L == -1) return -1;
            int R = MaxDepth(root.right);
            if (R == -1) return -1;
            return (Math.Abs(L - R) <= 1) ? (Math.Max(L, R) + 1) : -1;
        }
    }
}

