using System.Collections.Generic;
/*
 * 118. Pascal's Triangle
 * https://leetcode.com/problems/pascals-triangle/
 */
namespace Generate
{
    /*
     * Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
     *
     * Example:
     * Input: 5
     *
     * Output:
     * [
     *     [1],
     *    [1,1],
     *   [1,2,1],
     *  [1,3,3,1],
     * [1,4,6,4,1]
     * ]
     */
    class Program
    {
        static void Main(string[] args)
        {
            var result = Generate(5);
        }

        public static IList<IList<int>> Generate(int numRows)
        {
            var rows = new List<IList<int>>();

            for (var i = 0; i < numRows; i++)
            {
                var row = new List<int>();

                for (var j = 0; j < i + 1; j++)
                {
                    // if is first or last
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        // access previous row and the cells value
                        var a = rows[i - 1][j - 1];
                        var b = rows[i - 1][j];
                        row.Add(a + b);
                    }
                }

                rows.Add(row);
            }

            return rows;
        }
    }
}
