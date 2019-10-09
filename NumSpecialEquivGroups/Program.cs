using System;
using System.Collections.Generic;
using System.Text;

/*
 * 893. Groups of Special-Equivalent Strings
 * https://leetcode.com/problems/groups-of-special-equivalent-strings/
 */
namespace NumSpecialEquivGroups
{
    class Program
    {
        /*
         * You are given an array A of strings.
         * Two strings S and T are special-equivalent if after any number of moves, S == T.
         *
         * A move consists of choosing two indices i and j with i % 2 == j % 2, and swapping S[i] with S[j].
         * Now, a group of special-equivalent strings from A is a non-empty subset S of A such
         * that any string not in S is not special-equivalent with any string in S.
         *
         * Return the number of groups of special-equivalent strings from A.
         *
         * Example 1:
         * Input: ["a","b","c","a","c","c"]
         * Output: 3
         * Explanation: 3 groups ["a","a"], ["b"], ["c","c","c"]
         *
         * Example 2:
         * Input: ["aa","bb","ab","ba"]
         * Output: 4
         * Explanation: 4 groups ["aa"], ["bb"], ["ab"], ["ba"]
         *
         * Example 3:
         * Input: ["abc","acb","bac","bca","cab","cba"]
         * Output: 3
         * Explanation: 3 groups ["abc","cba"], ["acb","bca"], ["bac","cab"]
         *
         * Example 4:
         * Input: ["abcd","cdab","adcb","cbad"]
         * Output: 1
         * Explanation: 1 group ["abcd","cdab","adcb","cbad"]
         *
         * Note:
         * 1 <= A.length <= 1000
         * 1 <= A[i].length <= 20
         * All A[i] have the same length.
         * All A[i] consist of only lowercase letters.
         *
         */
        static void Main(string[] args)
        {
            var result = NumSpecialEquivGroups(new[] { "a", "b", "c", "a", "c", "c" });
            var result2 = NumSpecialEquivGroups(new[] { "aa", "bb", "ab", "ba" });
            var result3 = NumSpecialEquivGroups(new[] { "abc", "acb", "bac", "bca", "cab", "cba" });
            var result4 = NumSpecialEquivGroups(new[] { "abcd", "cdab", "adcb", "cbad" });
        }

        public static int NumSpecialEquivGroups(string[] A)
        {
            var seen = new HashSet<string>();
            var evens = new StringBuilder();
            var odds = new StringBuilder();

            foreach (var s in A)
            {
                evens.Clear();
                odds.Clear();

                for (var i = 0; i < s.Length; i += 2)
                {
                    evens.Append(s[i]);
                }

                for (var i = 1; i < s.Length; i += 2)
                {
                    odds.Append(s[i]);
                }

                var ev = evens.ToString().ToCharArray();
                var od = odds.ToString().ToCharArray();

                Array.Sort(ev);
                Array.Sort(od);

                seen.Add($"{new string(ev)}{new string(od)}");
            }

            return seen.Count;
        }
    }
}
