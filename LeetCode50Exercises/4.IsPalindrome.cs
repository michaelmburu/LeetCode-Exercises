using System;
namespace LeetCode50Exercises
{
    public class IsPalindrome
    {
        /*
            Given a string determine if it is a palindrome considering alphanumeric characters
            and ignoring cases

        Example Jack
        1st loop s[i] = j, s[j] = k

        */
        public bool IsPalindrome(string s)
        {
            //O(n)
            //Jack
            int i = 0, j = s.Length - 1;
            while(i < j)
            {
                while (i < j && !Char.IsLetterOrDigit(s[i])) i++;
                while (i < j && !Char.IsLetterOrDigit(s[j])) j--;
                if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}

