/*
 * 665. Non-decreasing Array
 * https://leetcode.com/problems/non-decreasing-array/
 */
namespace CheckPossibility
{
    class Program
    {
        /*
         * Given an array nums with n integers, your task is to check if it could become non-decreasing by modifying at most 1 element.
         * We define an array is non-decreasing if nums[i] <= nums[i + 1] holds for every i (0-based) such that (0 <= i <= n - 2).
         *
         * Example 1:
         * Input: nums = [4,2,3]
         * Output: true
         * Explanation: You could modify the first 4 to 1 to get a non-decreasing array.
         *
         * Example 2:
         * Input: nums = [4,2,1]
         * Output: false
         * Explanation: You can't get a non-decreasing array by modify at most one element.
         *
         * Constraints:
         * 1 <= n <= 10 ^ 4
         * - 10 ^ 5 <= nums[i] <= 10 ^ 5
         *
         */
        static void Main(string[] args)
        {
            var result = CheckPossibility(new[] { 4, 2, 3 });
            var result2 = CheckPossibility(new[] { 4, 2, 1 });
        }

        public static bool CheckPossibility(int[] nums)
        {
            //the number of changes
            var cnt = 0;

            for (var i = 1; i < nums.Length && cnt <= 1; i++)
            {
                //if current number greater than previous number
                if (nums[i] >= nums[i - 1])
                {
                    continue;
                }

                cnt++;

                if (i - 2 < 0 || nums[i - 2] <= nums[i])
                {
                    //modify nums[i-1] of a priority
                    nums[i - 1] = nums[i];
                }
                else
                {
                    //have to modify nums[i]
                    nums[i] = nums[i - 1];
                }
            }

            return cnt <= 1;
        }
    }
}
