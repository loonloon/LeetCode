using System;
using System.Collections.Generic;
/*
 * 219. Contains Duplicate II
 * https://leetcode.com/problems/contains-duplicate-ii/
 */
namespace ContainsNearbyDuplicate
{
    class Program
    {
        /*
         * Given an array of integers and an integer k, find out whether there are two distinct indices i and j
         * in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.
         *
         * Example 1:
         * Input: nums = [1,2,3,1], k = 3
         * Output: true
         *
         * Example 2:
         * Input: nums = [1,0,1,1], k = 1
         * Output: true
         *
         * Example 3:
         * Input: nums = [1,2,3,1,2,3], k = 2
         * Output: false
         *
         */
        static void Main(string[] args)
        {
            var result = ContainsNearbyDuplicate(new[] { 1, 2, 3, 1 }, 3);
            var result2 = ContainsNearbyDuplicate(new[] { 1, 0, 1, 1 }, 1);
            var result3 = ContainsNearbyDuplicate(new[] { 1, 2, 3, 1, 2, 3 }, 2);
        }

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var hashSet = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i]))
                {
                    return true;
                }

                hashSet.Add(nums[i]);

                if (hashSet.Count > k)
                {
                    //remove old entry
                    hashSet.Remove(nums[Math.Max(i - k, 0)]);
                }
            }

            return false;

            //for (var i = 0; i < nums.Length; i++)
            //{
            //    for (var j = i + 1; j < nums.Length; j++)
            //    {
            //        if ((nums[i] == nums[j]) && ((j - i) <= k))
            //        {
            //            return true;
            //        }
            //    }
            //}

            //return false;
        }
    }
}
