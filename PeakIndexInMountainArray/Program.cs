﻿/*
 * 852. Peak Index in a Mountain Array
 * https://leetcode.com/problems/peak-index-in-a-mountain-array/description/
 *
 */
namespace PeakIndexInMountainArray
{
    class Program
    {
        /*
         * Let's call an array A a mountain if the following properties hold:
         * A.length >= 3
         * There exists some 0 < i < A.length - 1 such that A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1]
         *
         * Given an array that is definitely a mountain,
         * return any i such that A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1]
         *
         * Example 1:
         * Input: [0,1,0]
         * Output: 1
         *
         * Example 2:
         * Input: [0,2,1,0]
         * Output: 1
         *
         * Note:
         * 1. 3 <= A.length <= 10000
         * 2. 0 <= A[i] <= 10^6
         * 3. A is a mountain, as defined above
         *
         */
        static void Main(string[] args)
        {
            var result = PeakIndexInMountainArray(new[] { 0, 1, 1 });
            var result2 = PeakIndexInMountainArray(new[] { 0, 2, 1, 0 });
        }

        public static int PeakIndexInMountainArray(int[] A)
        {
            for (var i = 1; i + 1 < A.Length; ++i)
            {
                if (A[i] > A[i + 1])
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
