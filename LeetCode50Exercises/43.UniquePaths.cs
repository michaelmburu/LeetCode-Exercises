using System;
namespace LeetCode50Exercises
{
    public class UniquePaths
    {
        public int backtrack(int r, int c, int m, int n)
        {
            if (r == m - 1 && c == n - 1) return 1;
            if (r >= m || c >= n) return 0;

            return backtrack(r + 1, c, m, n) + backtrack(r, c + 1, m, n);
        }

        public int uniquePaths(int m, int n)
        {
            return backtrack(0, 0, m, n);
        }
    }
}

