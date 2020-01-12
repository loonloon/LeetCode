using System;
/*
 * 581. Shortest Unsorted Continuous Subarray
 * https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
 */
namespace FindUnsortedSubarray
{
    class Program
    {
        /*
         * Given an integer array, you need to find one continuous subarray that if you only sort this subarray in ascending order, then the whole array will be sorted in ascending order, too.
         * You need to find the shortest such subarray and output its length.
         *
         * Example 1:
         * Input: [2, 6, 4, 8, 10, 9, 15]
         * Output: 5
         * Explanation: You need to sort [6, 4, 8, 10, 9] in ascending order to make the whole array sorted in ascending order.
         *
         * Note:
         * Then length of the input array is in range [1, 10,000].
         * The input array may contain duplicates, so ascending order here means <=.
         *
         */
        static void Main(string[] args)
        {
            var result = FindUnsortedSubarray(new[] { 2, 6, 4, 8, 10, 9, 15 });
        }

        public static int FindUnsortedSubarray(int[] nums)
        {
            var n = nums.Length;
            //if the nums is sorted, then it can become zero
            var head = -1;
            var tail = -2;
            var min = nums[n - 1];
            var max = nums[0];

            for (var i = 1; i < n; i++)
            {
                var tailIndex = n - 1 - i;
                min = Math.Min(min, nums[tailIndex]);
                max = Math.Max(max, nums[i]);

                if (nums[i] < max)
                {
                    tail = i;
                }

                if (nums[tailIndex] > min)
                {
                    head = tailIndex;
                }
            }

            return tail - head + 1;

            //var n = nums.Length;
            //var temp = new int[n];

            //for (var i = 0; i < n; i++)
            //{
            //    temp[i] = nums[i];
            //}

            //Array.Sort(temp);

            //var start = -1;
            //var end = -1;

            //for (var i = 0; i < n; i++)
            //{
            //    if (nums[i] == temp[i])
            //    {
            //        continue;
            //    }

            //    if (start == -1)
            //    {
            //        start = i;
            //    }

            //    end = i;
            //}

            //var count = end - start;
            //return count == 0 ? count : count + 1;
        }
    }
}
