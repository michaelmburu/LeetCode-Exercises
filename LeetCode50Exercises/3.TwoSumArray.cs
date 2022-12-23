using System;
namespace LeetCode50Exercises
{
    public class twoSign
    {
        /*
            Design and impliment a TwoSum class. It should support following operations add and find
            add(input)
            find(value)

            Example: add(1) add(2) add(5): find(4) > True, find(7) false

            Solution: Store all possible sums in a hash table, add goes through the list and stores new pair sums
            Find operation involves a single hash table lookup O(1)
        */

        //Add O(n), Find O(1)
        private Dictionary<int, int> table = new Dictionary<int, int>();

        public void add(int input)
        {
            //Check if table contains input and add if not
            int count = table.ContainsKey(input) ? table.GetValueOrDefault(input) : 0;
            table.Add(input, count + 1);
        }

        public Boolean find(int val)
        {
            Dictionary<int, int> entry = table;
            int num = entry.GetValueOrDefault(val);
            int y = val - num;
            if(y == num)
            {
                //For duplicates ensure there is two individual numbers
                if(entry.GetValueOrDefault(y) >= 2)
                {
                    return true;
                }
                else if (table.ContainsKey(y))
                {
                    return true;
                }
            }
            return false;
        }

    }
}

