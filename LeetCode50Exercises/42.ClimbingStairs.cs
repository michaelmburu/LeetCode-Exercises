using System;
namespace LeetCode50Exercises
{
    public class ClimbingStairs
    {
        /*
         * You're climbing a stairs. It takes n steps. You can either climb n
         * steps
        */
        public int ClimbStairs(int n)
        {
            int p = 1, q = 1;
            for(int i = 2; i <= n; i++)
            {
                int temp = q;
                q += p;
                p = temp;
            }

            return q;
        }
    }
}

