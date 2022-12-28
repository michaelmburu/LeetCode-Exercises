using System;
namespace LeetCode50Exercises
{
    public class SingleNumber
    {
        public int SingleNumberV2(int[] A, int n)
        {
            int[] count = { 0 };
            int result = 0;
            for(int i = 0; i < 32; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if ((A[j] >> i) & 1)
                    {
                        count[i]++;
                    }
                }

                result |= ((count[i] % 3) << i);
            }

            return result;
        }
    }
}

