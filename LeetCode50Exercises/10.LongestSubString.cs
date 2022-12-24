using System;
namespace LeetCode50Exercises
{
    public class LongestSubstring
    {
        /*
         * Given a string, find the length of the longest substring without repeating characters
         * O(n) runtime
        */
        public int lengthOfLongestSubstring(string s)
        {
            bool[] exist = new bool[256];
            int i = 0, maxLen = 0;
            for(int j = 0; j < s.Length; j++)
            {
                while (exist[s[j]])
                {
                    exist[s[j]] = false;
                    i++;
                }
                exist[s[j]] = true;
                maxLen = Math.Max(j - i + 1, maxLen);
            }

            return maxLen;
        }
    }
}

