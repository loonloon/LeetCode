/*
 * 977. Squares of a Sorted Array
 * https://leetcode.com/problems/squares-of-a-sorted-array/
 *
 */

using System;

namespace SortedSquares
{
    class Program
    {
        /*
         * Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.
         *
         * Example 1:
         * Input: [-4,-1,0,3,10]
         * Output: [0,1,9,16,100]
         *
         * Example 2:
         * Input: [-7,-3,2,3,11]
         * Output: [4,9,9,49,121]
         *
         * Note:
         * 1 <= A.length <= 10000
         * -10000 <= A[i] <= 10000
         * A is sorted in non-decreasing order.
         *
         */
        static void Main(string[] args)
        {
            var result = SortedSquares(new[] { -4, -1, 0, 3, 10 });
            var result2 = SortedSquares(new[] { -7, -3, 2, 3, 11 });
        }

        public static int[] SortedSquares(int[] A)
        {
            var n = A.Length;
            var result = new int[n];
            int i = 0, j = n - 1;

            for (var p = n - 1; p >= 0; p--)
            {
                if (Math.Abs(A[i]) > Math.Abs(A[j]))
                {
                    result[p] = A[i] * A[i];
                    i++;
                }
                else
                {
                    result[p] = A[j] * A[j];
                    j--;
                }
            }

            return result;
        }
    }
}
