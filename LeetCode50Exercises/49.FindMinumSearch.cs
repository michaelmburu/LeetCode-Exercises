using System;
namespace LeetCode50Exercises
{
    public class MinimumSearch
    {
        public int findMin(int[] A)
        {
            int L = 0, R = A.Length - 1;
            while(L < R && A[L] >= A[R])
            {
                int M = (L + R) / 2;
                if (A[M] > A[R])
                {
                    L = M + 1;
                }
                else
                {
                    R = M;
                }
            }

            return A[L];
        }
    }
}

