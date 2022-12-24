using System;
namespace LeetCode50Exercises
{
    public class LongestSubstringTwoDistinct
    {
        /*
         * Given a string S, find the length of the longest substring T that,
         * that contains at most two distinct characters
         * Given S = "eceba
         * T is ece, length 3
        */
        public int lengthOfLongestSubstringDistinctTwo(string s)
        {
            int i = 0, j = 1, maxLen = 0;
            for(int k = 1; k < s.Length; k++)
            {
                if (s[k] == s[k - 1]) continue;
                if(j >= 0 && s[j] != s[k])
                {
                    maxLen = Math.Max(k - i, maxLen);
                    i = j + 1;
                }

                j = k + 1;
            }

            return Math.Max(s.Length - 1, maxLen);
        }
    }
}

