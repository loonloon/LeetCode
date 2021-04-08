using System;
using System.Collections.Generic;
/*
 * 3. Longest Substring Without Repeating Characters
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/
 */
namespace LengthOfLongestSubstring
{
    class Program
    {
        /*
         * Given a string s, find the length of the longest substring without repeating characters.
         *
         * Example 1:
         * Input: s = "abcabcbb"
         * Output: 3
         * Explanation: The answer is "abc", with the length of 3.
         *
         * Example 2:
         * Input: s = "bbbbb"
         * Output: 1
         * Explanation: The answer is "b", with the length of 1.
         *
         * Example 3:
         * Input: s = "pwwkew"
         * Output: 3
         * Explanation: The answer is "wke", with the length of 3.
         * Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
         *
         * Example 4:
         * Input: s = ""
         * Output: 0
         *
         * Constraints:
         * 0 <= s.length <= 5 * 104
         * s consists of English letters, digits, symbols and spaces.
         *
         */
        static void Main(string[] args)
        {
            var result = LengthOfLongestSubstring("abcabcbb");
            var result2 = LengthOfLongestSubstring("bbbbb");
            var result3 = LengthOfLongestSubstring("pwwkew");
            var result4 = LengthOfLongestSubstring("");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            //windows sliding
            var queue = new Queue<char>();
            var result = 0;

            foreach (var c in s)
            {
                while (queue.Contains(c))
                {
                    queue.Dequeue();
                }

                queue.Enqueue(c);
                result = Math.Max(result, queue.Count);
            }

            return result;

            //var result = 0;
            //var cache = new int[256];

            //for (int index = 0, position = 0; index < s.Length; index++)
            //{
            //    //if char is found in cache
            //    if (cache[s[index]] > 0)
            //    {
            //        position = Math.Max(position, cache[s[index]]);
            //    }

            //    //keep track position, and start from 1
            //    cache[s[index]] = index + 1;

            //    //position 100% less than or equal index
            //    result = Math.Max(result, index - position + 1);
            //}

            //return result;
        }
    }
}
