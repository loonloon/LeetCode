using System.Collections.Generic;

/*
 * 350. Intersection of Two Arrays II
 * https://leetcode.com/problems/intersection-of-two-arrays-ii/
 */
namespace Intersect
{
    class Program
    {
        /*
         * Given two arrays, write a function to compute their intersection.
         *
         * Example 1:
         * Input: nums1 = [1,2,2,1], nums2 = [2,2]
         * Output: [2,2]
         *
         * Example 2:
         * Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
         * Output: [4,9]
         *
         * Note:
         * Each element in the result should appear as many times as it shows in both arrays.
         * The result can be in any order.
         *
         * Follow up:
         * What if the given array is already sorted? How would you optimize your algorithm?
         * What if nums1's size is small compared to nums2's size? Which algorithm is better?
         * What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
         *
         */
        static void Main(string[] args)
        {
            var result = Intersect(new[] { 1, 2, 2, 1 }, new[] { 2, 2 });
            var result2 = Intersect(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 });
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var dictionary = new Dictionary<int, int>();
            var result = new List<int>();

            foreach (var num in nums1)
            {
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num] += 1;
                }
                else
                {
                    dictionary.Add(num, 1);
                }
            }

            foreach (var num in nums2)
            {
                if (!dictionary.ContainsKey(num) && dictionary[num] > 0)
                {
                    continue;
                }

                result.Add(num);
                dictionary[num] -= 1;
            }

            return result.ToArray();
        }
    }
}
