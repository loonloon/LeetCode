﻿/*
 * 389. Find the Difference
 * https://leetcode.com/problems/find-the-difference/description/
 */

namespace FindTheDifference
{
    class Program
    {
        /*
         * Given two strings s and t which consist of only lowercase letters.
         * String t is generated by random shuffling string s and then add one more letter at a random position.
         * Find the letter that was added in t.
         *
         * Example:
         * Input:
         * s = "abcd"
         * t = "abcde"
         *
         * Output:
         * e
         *
         * Explanation:
         * 'e' is the letter that was added.
         *
         */
        static void Main(string[] args)
        {
            var result = FindTheDifference("abcd", "abcde");
        }

        public static char FindTheDifference(string s, string t)
        {
            var chars = string.Concat(s, t).ToCharArray();
            var differentChar = '\0';

            foreach (var c in chars)
            {
                differentChar ^= c;
            }

            return differentChar;
        }
    }
}
