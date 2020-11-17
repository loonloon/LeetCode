using System.Collections.Generic;
/*
 * 228. Summary Ranges
 * https://leetcode.com/problems/summary-ranges/
 */
namespace SummaryRanges
{
    class Program
    {
        /*
         * You are given a sorted unique integer array nums.
         *
         * Return the smallest sorted list of ranges that cover all the numbers in the array exactly.
         * That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.
         *
         * Each range [a,b] in the list should be output as:
         * "a->b" if a != b
         * "a" if a == b
         *
         * Example 1:
         * Input: nums = [0,1,2,4,5,7]
         * Output: ["0->2","4->5","7"]
         * Explanation: The ranges are:
         * [0,2] --> "0->2"
         * [4,5] --> "4->5"
         * [7,7] --> "7"
         *
         * Example 2:
         * Input: nums = [0,2,3,4,6,8,9]
         * Output: ["0","2->4","6","8->9"]
         * Explanation: The ranges are:
         * [0,0] --> "0"
         * [2,4] --> "2->4"
         * [6,6] --> "6"
         * [8,9] --> "8->9"
         *
         * Example 3:
         * Input: nums = []
         * Output: []
         *
         * Example 4:
         * Input: nums = [-1]
         * Output: ["-1"]
         *
         * Example 5:
         * Input: nums = [0]
         * Output: ["0"]
         *
         * Constraints:
         * 0 <= nums.length <= 20
         * -231 <= nums[i] <= 231 - 1
         * All the values of nums are unique.
         * nums is sorted in ascending order.
         *
         */
        static void Main(string[] args)
        {
            var result = SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 });
            var result2 = SummaryRanges(new[] { 0, 2, 3, 4, 6, 8, 9 });
            var result3 = SummaryRanges(new int[] { });
            var result4 = SummaryRanges(new[] { -1 });
            var result5 = SummaryRanges(new[] { 0 });
        }

        public static IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();

            for (var i = 0; i < nums.Length; i++)
            {
                var currentNum = nums[i];

                while (i + 1 < nums.Length && (nums[i + 1] - nums[i]) == 1)
                {
                    i++;
                }

                result.Add(currentNum == nums[i] ? $"{currentNum}" : $"{currentNum}->{nums[i]}");
            }

            return result;
        }
    }
}
