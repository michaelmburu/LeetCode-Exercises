using System;
namespace LeetCode50Exercises
{
    public class LongestPalindromicSubstring
    {
        /*
         * Longest Palindromic Substring
         * 
         * Given a string S, find the longest palindromic substring in S. You
         * may assume that maximum length of s is 100 and there exists one unique 
         * longest substring
         * 
         * Find the longest common substring candidate
        */
        public string longestPalindromeString(string s)
        {
            int start = 0, end = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if(len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
        }

        private int expandAroundCenter(string s, int left, int right)
        {
            int L = left, R = right;
            while (L => 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }

            return R - L - 1;
        }
    }
}

