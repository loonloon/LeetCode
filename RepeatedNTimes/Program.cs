/*
 * 961. N-Repeated Element in Size 2N Array
 * https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
 */

using System;

namespace RepeatedNTimes
{
    class Program
    {
        /*
         * In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.
         * Return the element repeated N times.
         *
         * Example 1:
         * Input: [1,2,3,3]
         * Output: 3
         *
         * Example 2:
         * Input: [2,1,2,5,3,2]
         * Output: 2
         *
         * Example 3:
         * Input: [5,1,5,2,5,3,5,4]
         * Output: 5
         *
         * Note:
         * 4 <= A.length <= 10000
         * 0 <= A[i] < 10000
         * A.length is even
         *
         */
        static void Main(string[] args)
        {
            var result = RepeatedNTimes(new[] { 1, 2, 3, 3 });
            var result2 = RepeatedNTimes(new[] { 2, 1, 2, 5, 3, 2 });
            var result3 = RepeatedNTimes(new[] { 5, 1, 5, 2, 5, 3, 5, 4 });
        }

        public static int RepeatedNTimes(int[] A)
        {
            var count = new int[10000];

            for (var index = 0; index < A.Length; index++)
            {
                var a = A[index];

                if (count[a]++ == 1)
                {
                    return a;
                }
            }

            return -1;
        }
    }
}
