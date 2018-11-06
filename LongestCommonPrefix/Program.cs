/*
 * 14. Longest Common Prefix
 * https://leetcode.com/problems/longest-common-prefix/
 */

using System;

namespace LongestCommonPrefix
{
    /*
     * Write a function to find the longest common prefix string amongst an array of strings.
     * If there is no common prefix, return an empty string "".
     *
     * Example 1:
     * Input: ["flower","flow","flight"]
     * Output: "fl"
     *
     * Example 2:
     * Input: ["dog","racecar","car"]
     * Output: ""
     * Explanation: There is no common prefix among the input strings.
     *
     * Note:
     * All given inputs are in lowercase letters a-z.
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            var result = LongestCommonPrefix(new[] { "flower", "flow", "flight" });
            var result2 = LongestCommonPrefix(new[] { "dog", "racecar", "car" });
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            var prefix = strs[0];
            var index = 1;

            while (index < strs.Length)
            {
                while (strs[index].IndexOf(prefix, StringComparison.Ordinal) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }

                index++;
            }

            return prefix;
        }
    }
}
