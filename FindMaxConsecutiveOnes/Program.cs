using System;

/*
 * 485. Max Consecutive Ones
 * https://leetcode.com/problems/max-consecutive-ones/description/
 */
namespace FindMaxConsecutiveOnes
{
    class Program
    {
        /*
         * Given a binary array, find the maximum number of consecutive 1s in this array.
         *
         * Example 1:
         * Input: [1,1,0,1,1,1]
         * Output: 3
         *
         * Explanation:
         * The first two digits or the last three digits are consecutive 1s.
         * The maximum number of consecutive 1s is 3.
         *
         * Note:
         * The input array will only contain 0 and 1.
         * The length of input array is a positive integer and will not exceed 10,000
         *
         */
        static void Main(string[] args)
        {
            var result = FindMaxConsecutiveOnes(new[] { 1, 1, 0, 1, 1, 1 });
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            var count = 0;
            var result = 0;

            foreach (var num in nums)
            {
                if (num == 1)
                {
                    count++;
                    result = Math.Max(count, result);
                }
                else
                {
                    count = 0;
                }
            }

            return result;
        }
    }
}
