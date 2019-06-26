using System.Collections.Generic;
/*
 * 119. Pascal's Triangle II
 * https://leetcode.com/problems/pascals-triangle-ii/
 */
namespace GetRow
{
    class Program
    {
        /*
         * Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.
         * Note that the row index starts from 0.
         *
         * Example:
         * Input: 3
         * Output: [1,3,3,1]
         *
         * Follow up:
         * Could you optimize your algorithm to use only O(k) extra space?
         */
        static void Main(string[] args)
        {
            var result = GetRow(3);
        }

        public static IList<int> GetRow(int rowIndex)
        {
            var row = new List<int> { 1 };

            // set row values to 0 from index 1
            for (var i = 1; i < rowIndex + 1; i++)
            {
                row.Add(0);
            }

            // each row
            for (var i = 1; i < rowIndex + 1; i++)
            {
                // each row content
                for (var j = i; j >= 1; j--)
                {
                    row[j] += row[j - 1];
                }
            }

            return row;
        }
    }
}
