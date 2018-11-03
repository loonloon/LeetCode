using System.Collections.Generic;

/*
 * 1. Two Sum
 * https://leetcode.com/problems/two-sum/
 */

namespace TwoSum2
{
    /*
     * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     *
     * Example:
     * Given nums = [2, 7, 11, 15], target = 9,
     * Because nums[0] + nums[1] = 2 + 7 = 9,
     * return [0, 1].
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            var result = TwoSum(new[] {2, 7, 11, 15}, 9);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var numberToFind = target - nums[i];

                if (!dictionary.ContainsKey(numberToFind))
                {
                    dictionary[nums[i]] = i;
                }
                else
                {
                    return new[] {dictionary[numberToFind], i};
                }
            }

            return null;
        }
    }
}
