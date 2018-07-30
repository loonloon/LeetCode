/*
 * 821. Shortest Distance to a Character
 * https://leetcode.com/problems/shortest-distance-to-a-character/description/
 */

using System;

namespace ShortestToChar
{
    class Program
    {
        /*
         * Given a string S and a character C, return an array of integers representing the shortest distance from the character C
         * in the string.
         *
         * Example 1:
         * Input: S = "loveleetcode", C = 'e'
         * Output: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
         *
         * Note:
         * 1. S string length is in [1, 10000].
         * 2. C is a single character, and guaranteed to be in string S.
         * 3. All letters in S and C are lowercase.
         *
         */
        static void Main(string[] args)
        {
            var result = ShortestToChar("loveleetcode", 'e');
        }

        public static int[] ShortestToChar(string S, char C)
        {
            var res = new int[S.Length];
            var pos = -S.Length;

            for (var i = 0; i < S.Length; ++i)
            {
                if (S[i] == C)
                {
                    pos = i;
                }

                res[i] = i - pos;
            }

            for (var i = S.Length - 1; i >= 0; --i)
            {
                if (S[i] == C)
                {
                    pos = i;
                }

                res[i] = Math.Min(res[i], Math.Abs(i - pos));
            }

            return res;
        }
    }
}
