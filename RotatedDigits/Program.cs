﻿/*
 * 788. Rotated Digits
 * https://leetcode.com/problems/rotated-digits/description/
 */
namespace RotatedDigits
{
    class Program
    {
        /*
         * X is a good number if after rotating each digit individually by 180 degrees, we get a valid number that is different from X.
         * Each digit must be rotated - we cannot choose to leave it alone.
         *
         * A number is valid if each digit remains a digit after rotation. 0, 1, and 8 rotate to themselves; 2 and 5 rotate to each other;
         * 6 and 9 rotate to each other, and the rest of the numbers do not rotate to any other number and become invalid.
         *
         * Now given a positive number N, how many numbers X from 1 to N are good?
         *
         * Example:
         * Input: 10
         * Output: 4
         * Explanation:
         * There are four good numbers in the range [1, 10] : 2, 5, 6, 9.
         * Note that 1 and 10 are not good numbers, since they remain unchanged after rotating.
         *
         * Note:
         * N  will be in range [1, 10000].
         *
         */
        static void Main(string[] args)
        {
            var result = RotatedDigits(10);
        }

        public static int RotatedDigits(int N)
        {
            var count = 0;

            for (var i = 1; i <= N; i++)
            {
                if (IsValid(i))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool IsValid(int N)
        {
            var validFound = false;

            while (N > 0)
            {
                if (N % 10 == 2) validFound = true;
                if (N % 10 == 5) validFound = true;
                if (N % 10 == 6) validFound = true;
                if (N % 10 == 9) validFound = true;
                if (N % 10 == 3) return false;
                if (N % 10 == 4) return false;
                if (N % 10 == 7) return false;
                N = N / 10;
            }

            return validFound;
        }
    }
}
