using System;
namespace LeetCode50Exercises
{
    public class PlusOne
    {
        /*
         * Given a number represented as an array of digits, plus one to the 
         * other number
         * 
         * Iterate from the least signifact digit and simluate by adding one to it
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
            digits.Add(0);
            digits[0] = 1;
        }
    }
}

