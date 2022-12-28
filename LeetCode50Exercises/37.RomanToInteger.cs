using System;
namespace LeetCode50Exercises
{
    public class RomanToInteger
    {
        /*
         * Given a roman numeral, convert to  integer
        */

        private Dictionary<Char, int> map = new Dictionary<char, int>()
            {
                {'I', 1},{'V', 5}, {'X', 10}, {'L', 50}, {'C', 100},
                {'D', 500}, {'M', 1000}
            };

        private int RomanToInt(String s)
        {
            int prev = 0, total = 0;
            foreach (char c in s.ToCharArray())
            {
                int curr = map.GetValueOrDefault(c);
                total += (curr > prev) ? (curr - 2 * prev) : curr;
                prev = curr;
            }

            return total;
        }
    }
}

