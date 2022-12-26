using System;
namespace LeetCode50Exercises
{
    public class PalindromeNumber
    {
        public int isPalindrome(int num)
        {
            int rev = 0;
            if (num > 0)
            {
                while (num != 0)
                {
                    rev = rev * 10 + num % 10;
                    num /= 10;
                }        
            }

            return rev;
        }
    }
}

