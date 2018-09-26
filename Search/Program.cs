/*
 * 704. Binary Search
 * https://leetcode.com/problems/binary-search/
 */
namespace Search
{
    class Program
    {
        /*
         * Given a sorted (in ascending order) integer array nums of n elements and a target value,
         * write a function to search target in nums. If target exists, then return its index, otherwise return -1.
         *
         * Example 1:
         * Input: nums = [-1,0,3,5,9,12], target = 9
         * Output: 4
         * Explanation: 9 exists in nums and its index is 4
         *
         * Example 2:
         * Input: nums = [-1,0,3,5,9,12], target = 2
         * Output: -1
         * Explanation: 2 does not exist in nums so return -1
         *
         */
        static void Main(string[] args)
        {
            var result = Search(new[] { -1, 0, 3, 5, 9, 12 }, 9);
            var result2 = Search(new[] { -1, 0, 3, 5, 9, 12 }, 2);
        }

        public static int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
