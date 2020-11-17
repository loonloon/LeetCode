using System;
/*
 * 504. Base 7
 * https://leetcode.com/problems/base-7/
 */
namespace ConvertToBase7
{
    class Program
    {
        /*
         * Given an integer, return its base 7 string representation.
         *
         * Example 1:
         * Input: 100
         * Output: "202"
         *
         * Example 2:
         * Input: -7
         * Output: "-10"
         *
         * Note: The input will be in range of [-1e7, 1e7].
         *
         */
        static void Main(string[] args)
        {
            var result = ConvertToBase7(100);
            var result2 = ConvertToBase7(-7);
        }

        public static string ConvertToBase7(int num)
        {
            if (num < 0)
            {
                return $"-{ConvertToBase7(-num)}";
            }

            if (num < 7)
            {
                return $"{num}";
            }

            return ConvertToBase7(num / 7) + $"{num % 7}";
        }
    }
}
