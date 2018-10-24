/*
 * 674. Longest Continuous Increasing Subsequence
 * https://leetcode.com/problems/longest-continuous-increasing-subsequence/
 */

using System;

namespace FindLengthOfLCIS
{
    class Program
    {
        /*
         * Given an unsorted array of integers, find the length of longest continuous increasing subsequence (subarray).
         *
         * Example 1:
         * Input: [1,3,5,4,7]
         * Output: 3
         * Explanation: The longest continuous increasing subsequence is [1,3,5], its length is 3.
         * Even though [1,3,5,7] is also an increasing subsequence, it's not a continuous one where 5 and 7 are separated by 4.
         *
         * Example 2:
         * Input: [2,2,2,2,2]
         * Output: 1
         * Explanation: The longest continuous increasing subsequence is [2], its length is 1.
         *
         */
        static void Main(string[] args)
        {
            var result = FindLengthOfLCIS(new[] { 1, 3, 5, 4, 7 });
            var result2 = FindLengthOfLCIS(new[] { 2, 2, 2, 2, 2 });
        }

        public static int FindLengthOfLCIS(int[] nums)
        {
            var result = 0;
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                //if is first index or after greater than before
                if (i == 0 || nums[i - 1] < nums[i])
                {
                    result = Math.Max(result, ++count);
                }
                else
                {
                    count = 1;
                }
            }

            return result;
        }
    }
}
