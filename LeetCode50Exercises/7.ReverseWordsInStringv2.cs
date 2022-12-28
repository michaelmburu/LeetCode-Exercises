using System;
namespace LeetCode50Exercises
{
    public class ReverseWordsInString
    {
        /*
         * Similar to question 6 but with the following constraints
         * The input string does not contain a leading or trailing spaces
         * 
         * O(n) run time
        */
        public void ReverseWords(char[] s)
        {
            reverse(s, 0, s.Length);
            for(int i = 0, j = 0; j <= s.Length; j++)
            {
                if(j == s.Length || s[j] == ' ')
                {
                    reverse(s, i, j);
                    i = j + 1;
                }
            }
        }

        private void reverse(char[] s, int begin, int end)
        {
            for(int i = 0; i < (end - begin) / 2; i++)
            {
                char temp = s[begin + 1];
                s[begin + 1] = s[end - i -1];
                s[end - 1 - 1] = temp;
            }
        }
    }
}

