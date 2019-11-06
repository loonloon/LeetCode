﻿/*
 * 263. Ugly Number
 * https://leetcode.com/problems/ugly-number/
 */
namespace IsUgly
{
    class Program
    {
        /*
         * Write a program to check whether a given number is an ugly number.
         * Ugly numbers are positive numbers whose prime factors only include 2, 3, 5.
         *
         * Example 1:
         * Input: 6
         * Output: true
         * Explanation: 6 = 2 × 3
         *
         * Example 2:
         * Input: 8
         * Output: true
         * Explanation: 8 = 2 × 2 × 2
         *
         * Example 3:
         * Input: 14
         * Output: false
         * Explanation: 14 is not ugly since it includes another prime factor 7.
         *
         * Note:
         * 1 is typically treated as an ugly number.
         * Input is within the 32-bit signed integer range: [−231,  231 − 1].
         *
         */
        static void Main(string[] args)
        {
            var result = IsUgly(6);
            var result2 = IsUgly(8);
            var result3 = IsUgly(14);
        }

        public static bool IsUgly(int num)
        {
            var n = num;

            // 11 mod 4 = 3
            while (num > 0)
            {
                while (n % 2 == 0)
                {
                    n /= 2;
                }

                while (n % 3 == 0)
                {
                    n /= 3;
                }

                while (n % 5 == 0)
                {
                    n /= 5;
                }

                return n == 1;
            }

            return false;
        }
    }
}