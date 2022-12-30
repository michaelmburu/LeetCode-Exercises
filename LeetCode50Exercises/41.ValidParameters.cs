using System;
namespace LeetCode50Exercises
{
    public class ValidParameters
    {
        /*
         * Given a string containing just characters  
        */
        private static Dictionary<char, char> map = new Dictionary<char, char>()
        {
           
        };
        public bool isValid(String s)
        {
            Stack<Char> stack = new Stack<char>();
            foreach (char c in s.ToCharArray())
            {
                if (map.ContainsKey(c))
                {
                    stack.Push(c);
                }else if(stack.Count == 0 || map.GetValueOrDefault(stack.Pop()) != c)
                {
                    return false;
                }              
            }

            return stack.Count() == 0;
        }
    }
}

