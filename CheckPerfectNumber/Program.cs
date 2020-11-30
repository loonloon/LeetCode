/*
 * 507. Perfect Number
 * https://leetcode.com/problems/perfect-number/
 */

using System;

namespace CheckPerfectNumber
{
    class Program
    {
        /*
         * A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself.
         * A divisor of an integer x is an integer that can divide x evenly.
         *
         * Given an integer n, return true if n is a perfect number, otherwise return false.
         * Example 1:
         * Input: num = 28
         * Output: true
         * Explanation: 28 = 1 + 2 + 4 + 7 + 14
         * 1, 2, 4, 7, and 14 are all divisors of 28.
         *
         * Example 2:
         * Input: num = 6
         * Output: true
         *
         * Example 3:
         * Input: num = 496
         * Output: true
         *
         * Example 4:
         * Input: num = 8128
         * Output: true
         *
         * Example 5:
         * Input: num = 2
         * Output: false
         *
         * Constraints:
         * 1 <= num <= 108
         *
         */
        static void Main(string[] args)
        {
            var result = CheckPerfectNumber(28);
            var result2 = CheckPerfectNumber(6);
            var result3 = CheckPerfectNumber(496);
            var result4 = CheckPerfectNumber(8128);
            var result5 = CheckPerfectNumber(2);
        }

        public static bool CheckPerfectNumber(int num)
        {
            if (num == 1)
            {
                return false;
            }

            var sum = 1;
            var sqrt = Math.Sqrt(num);

            for (var i = 2; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    sum += i + num / i;
                }
            }

            return sum == num;
        }
    }
}
