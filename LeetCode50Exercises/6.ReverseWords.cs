using System;
using System.Text;

namespace LeetCode50Exercises
{
    public class ReverseWords
    {
        /*
         * Given a string input s, reverse the string word by word
         * Example "The Sky Is Blue" to "Blue Is Sky The"
        */
        public string ReverseWordsInString(string s)
        {
            StringBuilder reversed = new StringBuilder();
            int j = s.Length;

            // Iterate the string in reverse order and if we're at the beginning of a
            // Word append it
            for(int i = s.Length - 1; i > 0; i--)
            {
                if (Char.IsWhiteSpace(s[i]))
                {
                    j = 1;
                }
                else if(i == 0 || Char.IsWhiteSpace(s[i - 1]))
                {
                    if(reversed.Length != 0)
                    {
                        reversed.Append(' ');
                    }

                    reversed.Append(s.Substring(i, j));
                }
            }

            return reversed.ToString();
        }
    }
}

