using System.Collections.Generic;
using System.Linq;
/*
 * 1051. Height Checker
 * https://leetcode.com/problems/height-checker/
 */
namespace HeightChecker
{
    class Program
    {
        /*
         * Students are asked to stand in non-decreasing order of heights for an annual photo.
         * Return the minimum number of students not standing in the right positions.
         * (This is the number of students that must move in order for all students to be standing
         * in non-decreasing order of height.)
         *
         * Example 1:
         * Input: [1,1,4,2,1,3]
         * Output: 3
         * Explanation:
         * Students with heights 4, 3 and the last 1 are not standing in the right positions.
         *
         * Note:
         * 1 <= heights.length <= 100
         * 1 <= heights[i] <= 100
         *
         */
        static void Main(string[] args)
        {
            var result = HeightChecker(new[] { 1, 1, 4, 2, 1, 3 });
        }

        public static int HeightChecker(int[] heights)
        {
            var sortedHeights = new List<int>(heights);
            sortedHeights.Sort();
            return heights.Where((t, i) => t != sortedHeights[i]).Count();
        }
    }
}
