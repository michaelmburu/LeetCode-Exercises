using System;
namespace LeetCode50Exercises
{
    public class BitManipulation
    {
        public SingleNumber(int[] A)
        {
            Map<int, int> map = new HashMap();
            for(int x : A)
            {
                int count = map.containsKey(x) ? map.get(x) : 0;
                map.put(x, count);
            }
            throw new ArgumentException();
        }
    }
}

