using System.Collections.Generic;
/*
 * 414. Third Maximum Number
 * https://leetcode.com/problems/third-maximum-number/
 */
namespace ThirdMax
{
    class Program
    {
        /*
         * Given a non-empty array of integers, return the third maximum number in this array.
         * If it does not exist, return the maximum number. The time complexity must be in O(n).
         *
         * Example 1:
         * Input: [3, 2, 1]
         * Output: 1
         * Explanation: The third maximum is 1.
         *
         * Example 2:
         * Input: [1, 2]
         * Output: 2
         * Explanation: The third maximum does not exist, so the maximum (2) is returned instead.
         *
         * Example 3:
         * Input: [2, 2, 3, 1]
         * Output: 1
         * Explanation: Note that the third maximum here means the third maximum distinct number.
         * Both numbers with value 2 are both considered as second maximum.
         *
         */
        static void Main(string[] args)
        {
            var result = ThirdMax(new[] { 3, 2, 1 });
            var result2 = ThirdMax(new[] { 1, 2 });
            var result3 = ThirdMax(new[] { 2, 2, 3, 1 });
        }

        public static int ThirdMax(int[] nums)
        {
            var max = int.MinValue;
            var secondMax = int.MinValue;
            var thirdMax = int.MinValue;
            var distinctNumbers = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    //shift the value to back
                    // max to second
                    // second to third
                    thirdMax = secondMax;
                    secondMax = max;
                    max = nums[i];
                }

                if (nums[i] > secondMax && nums[i] < max)
                {
                    thirdMax = secondMax;
                    secondMax = nums[i];
                }

                if (nums[i] > thirdMax && nums[i] < secondMax)
                {
                    thirdMax = nums[i];
                }

                distinctNumbers.Add(nums[i]);
            }

            return distinctNumbers.Count >= 3 ? thirdMax : max;
        }
    }
}
