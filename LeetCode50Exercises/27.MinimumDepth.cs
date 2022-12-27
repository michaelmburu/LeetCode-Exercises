﻿using System;
namespace LeetCode50Exercises
{
    public class MinimumDepth
    {
        /*
         * Given a binary tree  
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

