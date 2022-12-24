using System;
namespace LeetCode50Exercises
{
    public class MissingRanges
    {
        public List<string> findMissingRanges(int[] vals, int start, int end)
        {
            List<string> ranges = new List<string>();
            int prev = start - 1;

            for(int i = 0; i <= vals.Length; i++)
            {
                int curr = (i == vals.Length) ? end + 1 : vals[i];
                if(curr - prev >= 2)
                {
                    ranges.Add(ranges.GetRange(prev + 1, curr - 1));
                }

                prev = curr;
            }

            return ranges;
        }
    }
}

