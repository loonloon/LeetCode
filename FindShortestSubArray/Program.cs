using System;
using System.Collections.Generic;

namespace FindShortestSubArray
{
    class Program
    {
        /*
         * Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.
         * Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.
         *
         * Example 1:
         * Input: [1, 2, 2, 3, 1]
         * Output: 2
         *
         * Explanation:
         * The input array has a degree of 2 because both elements 1 and 2 appear twice. Of the subarrays that have the same degree:
         * [1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
         * The shortest length is 2. So return 2.
         *
         * Example 2:
         * Input: [1,2,2,3,1,4,2]
         * Output: 6
         *
         * Note:
         * nums.length will be between 1 and 50,000.
         * nums[i] will be an integer between 0 and 49,999.
         *
         */
        static void Main(string[] args)
        {
            var result = FindShortestSubArray(new[] { 1 });
            var result2 = FindShortestSubArray(new[] { 1, 2, 2, 3, 1, 4, 2 });
        }

        public static int FindShortestSubArray(int[] nums)
        {
            var counter = new Dictionary<int, int>();
            var first = new Dictionary<int, int>();
            var shortestLength = 0;
            var degree = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                //store each number and index when first found
                if (!first.ContainsKey(nums[i]))
                {
                    first.Add(nums[i], i);
                }

                //store counter for each number
                if (counter.ContainsKey(nums[i]))
                {
                    counter[nums[i]] += 1;
                }
                else
                {
                    counter.Add(nums[i], 1);
                }

                //if any number exists more than 1
                if (counter[nums[i]] > degree)
                {
                    //set the number count to degree
                    degree = counter[nums[i]];
                    //get latest index when greater number count is found
                    shortestLength = i - first[nums[i]] + 1;
                }
                else if (counter[nums[i]] == degree)
                {
                    shortestLength = Math.Min(shortestLength, i - first[nums[i]] + 1);
                }
            }

            return shortestLength;
        }
    }
}
