/*
 * 349. Intersection of Two Arrays
 * https://leetcode.com/problems/intersection-of-two-arrays/description/
 */

using System.Linq;

namespace Intersection
{
    class Program
    {
        /*
         * Given two arrays, write a function to compute their intersection.
         *
         * Example:
         * Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].
         *
         * Note:
         * Each element in the result must be unique.
         * The result can be in any order.
         *
         */
        static void Main(string[] args)
        {
            var result = Intersection(new[] { 1, 2, 2, 1 }, new[] { 2, 2 });
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            return (from num1 in nums1
                    from num2 in nums2
                    where num1 == num2
                    select num1).Distinct().ToArray();
        }
    }
}
