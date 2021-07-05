﻿using System;
/*
 * 594. Longest Harmonious Subsequence
 * https://leetcode.com/problems/longest-harmonious-subsequence/
 */
namespace FindLHS
{
    class Program
    {
        /*
         * We define a harmonious array as an array where the difference between its maximum value and its minimum value is exactly 1.
         * Given an integer array nums, return the length of its longest harmonious subsequence among all its possible subsequences.
         *
         * A subsequence of array is a sequence that can be derived from the array by deleting some or no elements without changing the order of the remaining elements.
         *
         * Example 1:
         * Input: nums = [1,3,2,2,5,2,3,7]
         * Output: 5
         * Explanation: The longest harmonious subsequence is [3,2,2,2,3].
         *
         * Example 2:
         * Input: nums = [1,2,3,4]
         * Output: 2
         *
         * Example 3:
         * Input: nums = [1,1,1,1]
         * Output: 0
         *
         * Constraints:
         * 1 <= nums.length <= 2 * 104
         * 109 <= nums[i] <= 109
         *
         */
        static void Main(string[] args)
        {
            var result = FindLHS(new[] { 1, 3, 2, 2, 5, 2, 3, 7 });
            var result2 = FindLHS(new[] { 1, 2, 3, 4 });
            var result3 = FindLHS(new[] { 1, 1, 1, 1 });
        }

        public static int FindLHS(int[] nums)
        {
            Array.Sort(nums);
            var min = 0;
            var count = 0;

            for (var i = 1; i < nums.Length;)
            {
                if (nums[i] - nums[min] == 0)
                {
                    i++;
                }
                else if (nums[i] - nums[min] == 1)
                {
                    count = Math.Max(count, i - min + 1);
                    i++;
                }
                else
                {
                    min++;
                }
            }
            return count;
        }
    }
}
