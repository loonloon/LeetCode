using System;
/*
 * 231. Power of Two
 * https://leetcode.com/problems/power-of-two/
 */
namespace IsPowerOfTwo
{
    class Program
    {
        /*
         * Given an integer, write a function to determine if it is a power of two.
         * Example 1:
         * Input: 1
         * Output: true
         * Explanation: 20 = 1
         *
         * Example 2:
         * Input: 16
         * Output: true
         * Explanation: 24 = 16
         *
         * Example 3:
         * Input: 218
         * Output: false
         *
         */
        static void Main(string[] args)
        {
            var result = IsPowerOfTwo(3);
            var result2 = IsPowerOfTwo(16);
            var result3 = IsPowerOfTwo(218);
        }

        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            return !Convert.ToBoolean(n & (n - 1));

            //var result = 1;

            //while (n >= result)
            //{
            //    if (n == result)
            //    {
            //        return true;
            //    }

            //    result *= 2;
            //}

            //return false;
        }
    }
}
