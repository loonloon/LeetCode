/*
 * 136. Single Number
 * https://leetcode.com/problems/single-number/description/
 */

namespace SingleNumber
{
    class Program
    {
        /*
         * Given a non-empty array of integers, every element appears twice except for one. Find that single one.
         *
         * Note:
         * Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
         *
         * Example 1:
         * Input: [2,2,1]
         * Output: 1
         *
         * Example 2:
         * Input: [4,1,2,1,2]
         * Output: 4
         *
         */
        static void Main(string[] args)
        {
            var result = SingleNumber(new[] { 4, 1, 2, 1, 2 });
        }

        public static int SingleNumber(int[] nums)
        {
            var result = 0;

            /*
             * XOR ^
             * 0 0 0
             * 0 1 1
             * 1 0 1
             * 1 1 0
             *
             * AND &
             * 0 0 0
             * 0 1 0
             * 1 0 0
             * 1 1 1
             */

            for (var i = 0; i < nums.Length; i++)
            {
                /*
                 * 4 = 0000 0100
                 * 1 = 0000 0010
                 * 2 = 0000 0100
                 * 1 = 0000 0010
                 * 2 = 0000 0100
                 */
                result ^= nums[i];
            }

            return result;
        }
    }
}
