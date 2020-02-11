﻿/*
 * 1304. Find N Unique Integers Sum up to Zero
 * https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
 */
namespace SumZero
{
    class Program
    {
        /*
         * Given an integer n, return any array containing n unique integers such that they add up to 0.
         *
         * Example 1:
         * Input: n = 5
         * Output: [-7,-1,1,3,4]
         * Explanation: These arrays also are accepted [-5,-1,1,2,3] , [-3,-1,2,-2,4].
         *
         * Example 2:
         * Input: n = 3
         * Output: [-1,0,1]
         *
         * Example 3:
         * Input: n = 1
         * Output: [0]
         *
         * Constraints:
         * 1 <= n <= 1000
         *
         */
        static void Main(string[] args)
        {
            var result = SumZero(5);
            var result2 = SumZero(3);
            var result3 = SumZero(1);
        }

        public static int[] SumZero(int n)
        {
            /*
             * Intuition
             * Naive idea
             * n = 1, [0]
             * n = 2, [-1, 1]
             *
             * Now write more based on this
             * n = 3, [-2, 0, 2]
             * n = 4, [-3, -1, 1, 3]
             * n = 5, [-4, -2, 0, 2, 4]
             *
             * It spreads like the wave.
             *
             * Explanation
             * Find the rule
             * A[i] = i * 2 - n + 1
             *
             */
            var result = new int[n];

            for (var i = 0; i < n; i++)
            {
                result[i] = i * 2 - n + 1;
            }

            return result;
        }
    }
}
