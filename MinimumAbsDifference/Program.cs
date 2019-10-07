using System;
using System.Collections.Generic;
/*
 * 1200. Minimum Absolute Difference
 * https://leetcode.com/problems/minimum-absolute-difference/
 */
namespace MinimumAbsDifference
{
    class Program
    {
        /*
         * Given an array of distinct integers arr, find all pairs of elements with the minimum absolute difference of any two elements.
         * Return a list of pairs in ascending order(with respect to pairs), each pair [a, b] follows
         * a, b are from arr
         * a < b
         * b - a equals to the minimum absolute difference of any two elements in arr
         *
         * Example 1:
         * Input: arr = [4,2,1,3]
         * Output: [[1,2],[2,3],[3,4]]
         * Explanation: The minimum absolute difference is 1. List all pairs with difference equal to 1 in ascending order.
         *
         * Example 2:
         * Input: arr = [1,3,6,10,15]
         * Output: [[1,3]]
         *
         * Example 3:
         * Input: arr = [3,8,-10,23,19,-4,-14,27]
         * Output: [[-14,-10],[19,23],[23,27]]
         *
         * Constraints:
         * 2 <= arr.length <= 10^5
         * -10^6 <= arr[i] <= 10^6
         *
         */
        static void Main(string[] args)
        {
            var result = MinimumAbsDifference(new[] { 4, 2, 1, 3 });
            var result2 = MinimumAbsDifference(new[] { 1, 3, 6, 10, 15 });
            var result3 = MinimumAbsDifference(new[] { 3, 8, -10, 23, 19, -4, -14, 27 });
        }

        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            var list = new List<IList<int>>();
            var min = int.MaxValue;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                min = Math.Min(arr[i + 1] - arr[i], min);
            }

            for (var i = 0; i < arr.Length - 1; i++)
            {
                var difference = arr[i + 1] - arr[i];

                if (difference == min)
                {
                    list.Add(new List<int>(new[] { arr[i], arr[i + 1] }));
                }
            }

            return list;
        }
    }
}
