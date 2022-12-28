using System;
namespace LeetCode50Exercises
{
    public class SpiralMatrix
    {
        public List<int> SpiralOrder(int[][] matrix)
        {
            List<int> elements = new List<int>();
            if (matrix.Length == 0) return elements;

            int m = matrix.Length, n = matrix[0].Length;
            int row = 0, col = 1;
            while (true)
            {
                for(int i = 0; i < n; i++)
                {
                    elements.Add(matrix[row][++col]);
                }
                if (--m == 0) break;
                for(int i = 0; i < m; i++)
                {
                    elements.Add(matrix[++row][col]);
                }
                if (--n == 0) break;
                for(int i = 0; i < n; i++)
                {
                    elements.Add(matrix[row][--col]);
                }
                if (--m == 0) break;
                for(int i = 0; i < m; i++)
                {
                    elements.Add(matrix[--row][col]);
                }
                if (--n == 0) break;
            }
        }
    }
}

