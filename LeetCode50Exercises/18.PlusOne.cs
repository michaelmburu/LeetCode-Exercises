using System;
namespace LeetCode50Exercises
{
    public class PlusOne
    {
        /*
         * Given a number represented as an array of digits, plus one to the 
         * other number
        */
        public void plusOne(List<int> digits)
        {
            for(int i = digits.Count - 1; i > 0; i--)
            {
                int digit = digits[i];
                if(digit < 9)
                {
                    digits[i] = digit + 1;
                    return;
                }
                else
                {
                    digits[i] = 0;
                }
            }
        }
    }
}

