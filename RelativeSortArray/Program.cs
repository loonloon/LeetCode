using System;
using System.Collections.Generic;
/*
 * 1122. Relative Sort Array
 * https://leetcode.com/problems/relative-sort-array/
 */
namespace RelativeSortArray
{
    class Program
    {
        /*
         * Given two arrays arr1 and arr2, the elements of arr2 are distinct, and all elements in arr2 are also in arr1.
         * Sort the elements of arr1 such that the relative ordering of items in arr1 are the same as in arr2.
         * Elements that don't appear in arr2 should be placed at the end of arr1 in ascending order.
         *
         * Example 1:
         * Input: arr1 = [2,3,1,3,2,4,6,7,9,2,19], arr2 = [2,1,4,3,9,6]
         * Output: [2,2,2,1,4,3,3,9,6,7,19]
         *
         * Constraints:
         * arr1.length, arr2.length <= 1000
         * 0 <= arr1[i], arr2[i] <= 1000
         * Each arr2[i] is distinct.
         * Each arr2[i] is in arr1.
         *
         */
        static void Main(string[] args)
        {
            var result = RelativeSortArray(new[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new[] { 2, 1, 4, 3, 9, 6 });
        }

        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var count = new int[1001];

            for (var i = 0; i < arr1.Length; i++)
            {
                count[arr1[i]]++;
            }

            var result = new int[arr1.Length];
            var currentIndex = 0;

            for (var i = 0; i < arr2.Length; i++)
            {
                while (count[arr2[i]] > 0)
                {
                    result[currentIndex++] = arr2[i];
                    count[arr2[i]]--;
                }
            }

            for (var i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    result[currentIndex++] = i;
                    count[i]--;
                }
            }

            return result;
        }
    }
}
