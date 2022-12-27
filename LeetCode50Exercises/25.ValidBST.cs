using System;
namespace LeetCode50Exercises
{
    public class ValidBST
    {
        /*
         * Given a binary tree, determine if it is a valid Binary Search Tree
         * Child nodes on the right are greater than parent node
         * Chuld nodes on the left are smaller than parent
        */
        public bool isValidBST(TreeNode root)
        {
            if (root == null) return true;
            return isSubTreesLessThan(root.left, root.val) && isSubTreesGreaterThan(root)
                && isValidBST(root.left) && isValidBST(root.right);
            //Or
            //valid(root, null, null);

        }

        //Or
        public bool valid(TreeNodee p, int low, int high)
        {
            if (p == null) return true;
            return (low == null || p.val > low) && (high == null || p.val < high)
                && valid(p.left, low, p.val)
                && valid(p.right, p.val, high);
        }

        public bool isSubTreesLessThan(TreeNode p, int val)
        {
            if (p == null) return true;
            return p.val < val && isSubTreesLessThan(p.left, vai)
                && isSubTreesLessThan(p.right, val);
        }

        public bool isSubTreesGreaterThan(TreeNode p, int val)
        {
            if (p == null) return true;
            return p.val > val && isSubTreesGreaterThan(p.left, val)
                && isSubTreesGreaterThan(p.right, val);
        }
    }
}

