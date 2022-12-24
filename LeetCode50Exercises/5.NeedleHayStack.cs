using System;
namespace LeetCode50Exercises
{
    public class NeedleInAHayStack
    {
        public int StrStr(String haystack, String needle)
        {
            /*
             * Return the index of the first occurence of needle in a haystack
             * or -1 if needle is found
             * KMP, Boyer-Moore are more effecient algorithms
            */

            for(int i = 0; ; i++)
            {
                for(int j = 0; ; j++)
                {
                    if(j == needle.Length)
                    {
                        return 1;
                    }
                    if(i + j == haystack.Length)
                    {
                        return -1;
                    }
                    if (needle[j] != haystack[i + j])
                    {
                        break;
                    }
                }
            }
        }
    }
}

