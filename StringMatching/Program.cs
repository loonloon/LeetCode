﻿using System.Collections.Generic;
using System.Linq;

/*
 * 1408. String Matching in an Array
 * https://leetcode.com/problems/string-matching-in-an-array/
 *
 */
namespace StringMatching
{
    class Program
    {
        /*
         * Given an array of string words. Return all strings in words which is substring of another word in any order.
         * String words[i] is substring of words[j], if can be obtained removing some characters to left and/or right side of words[j].
         *
         * Example 1:
         * Input: words = ["mass","as","hero","superhero"]
         * Output: ["as","hero"]
         * Explanation: "as" is substring of "mass" and "hero" is substring of "superhero".
         * ["hero","as"] is also a valid answer.
         *
         * Example 2:
         * Input: words = ["leetcode","et","code"]
         * Output: ["et","code"]
         * Explanation: "et", "code" are substring of "leetcode".
         *
         * Example 3:
         * Input: words = ["blue","green","bu"]
         * Output: []
         *
         * Constraints:
         * 1 <= words.length <= 100
         * 1 <= words[i].length <= 30
         * words[i] contains only lowercase English letters.
         * It's guaranteed that words[i] will be unique.
         *
         */
        static void Main(string[] args)
        {
            var result = StringMatching(new[] { "mass", "as", "hero", "superhero" });
            var result2 = StringMatching(new[] { "leetcode", "et", "code" });
            var result3 = StringMatching(new[] { "blue", "green", "bu" });
        }

        public static IList<string> StringMatching(string[] words)
        {
            var result = new HashSet<string>();

            for (var i = 0; i < words.Length; i++)
            {
                for (var j = 0; j < words.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (words[i].Contains(words[j]))
                    {
                        result.Add(words[j]);
                    }

                    if (words[j].Contains(words[i]))
                    {
                        result.Add(words[i]);
                    }
                }
            }

            return result.ToList();
        }
    }
}
