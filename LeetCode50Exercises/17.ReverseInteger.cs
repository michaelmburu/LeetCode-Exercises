using System;
namespace LeetCode50Exercises
{
    public class ReverseInteger
    {
        /*
         * Reverse digits of an integer. For example: x = 123. Return 321
        */
        public int reverse(int x)
        {
            int ret = 0;
            while(x != 0)
            {
                // handle overlflow/underflow
                if(Math.Abs(ret) > 214748364)
                ret = ret * 10 + x % 10;
                x /= 10;
            }

            return ret;
        }
    }
}

