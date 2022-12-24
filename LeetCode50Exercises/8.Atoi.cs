using System;
namespace LeetCode50Exercises
{
    public class StringToInteger
    {
        private static int maxDiv10 = int.MaxValue / 10;
        public int atoi(string str)
        {
            int i = 0, n = str.Length;
            while (i < n && Char.IsWhiteSpace(str[1])) i++;
            int sign = 1;
            if(i < n && str[i] == ' ')
            {
                i++;
            }
            else if(i < n && str[i] == '-'){
                sign = -1;
                i++;
            }

            int num = 0;
            while(i < n && char.IsDigit(str[i]))
            {
                int digit = ((int)Char.GetNumericValue(str[i]));
                if(num > maxDiv10 || num == maxDiv10 && digit >= 8)
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }

                num = num * 10 + digit;
                i++;
            }

            return sign * num;
        }
    }
}

