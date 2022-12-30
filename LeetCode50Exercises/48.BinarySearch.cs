using System;
namespace LeetCode50Exercises
{
    public class BinarySearch
    {
        public int searchInsert(int[] A, int target)
        {
            int L = 0, R = A.Length - 1;

            while(L < R)
            {
                int M = (L + R) / 2;
                if (A[M] < target)
                {
                    L = M + 1;
                }
                else
                {
                    R = M;
                }
            }

            return (A[L] < target) ? L + 1 : L;
        }
    }
}

