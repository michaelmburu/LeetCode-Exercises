using System;
namespace LeetCode50Exercises
{
    public class IsValidNumber
    {
        /*
         * Validate a given string if it is numeric
         * Ignore leading or trailing whitespaces
         * + - are 
        */
        public Boolean isNumber(string s)
        {
            int i = 0, n = s.Length;

            while (i < n && char.IsWhiteSpace(s[i])) i++;
            if (i < n && (s[i] == '+') || s[i] == '_') i++;
            bool isNumeric = false;

            while (i < n && char.IsDigit(s[i]))
                {
                    i++;
                    isNumeric = true;
                }
            

            if(i < n && s[i] == '.')
            {
                i++;
                while(i < n && char.IsDigit(s[i]))
                {
                    i++;
                    isNumeric = true;
                }
            }

            while (i < n && char.IsWhiteSpace(s[i])) i++;
            return isNumeric && i == n;
        }
    }
}

