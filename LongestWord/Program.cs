using System;
using System.Collections.Generic;
/*
 * 720. Longest Word in Dictionary
 * https://leetcode.com/problems/longest-word-in-dictionary/description/
 */
namespace LongestWord
{
    class Program
    {
        /*
         * Given a list of strings words representing an English Dictionary,
         * find the longest word in words that can be built one character at a time by other words in words. If there is more than one possible answer, return the longest word with the smallest lexicographical order.
         *
         * If there is no answer, return the empty string.
         * Example 1:
         * Input:
         * words = ["w","wo","wor","worl", "world"]
         * Output: "world"
         *
         * Explanation:
         * The word "world" can be built one character at a time by "w", "wo", "wor", and "worl".
         *
         * Example 2:
         * Input:
         * words = ["a", "banana", "app", "appl", "ap", "apply", "apple"]
         * Output: "apple"
         *
         * Explanation:
         * Both "apply" and "apple" can be built from other words in the dictionary.
         * However, "apple" is lexicographically smaller than "apply".
         *
         * Note:
         * All the strings in the input will only contain lowercase letters.
         * The length of words will be in the range [1, 1000].
         * The length of words[i] will be in the range [1, 30].
         *
         */
        static void Main(string[] args)
        {
            var result = LongestWord(new[] { "w", "wo", "wor", "worl", "world" });
            var result2 = LongestWord(new[] { "a", "banana", "app", "appl", "ap", "apply", "apple" });
        }

        public static string LongestWord(string[] words)
        {
            Array.Sort(words);
            var hashSet = new List<string>();
            var longestWord = string.Empty;

            foreach (var word in words)
            {
                if (word.Length == 1 || hashSet.Contains(word.Substring(0, word.Length - 1)))
                {
                    longestWord = word.Length > longestWord.Length ? word : longestWord;
                    hashSet.Add(word);
                }
            }

            return longestWord;
        }
    }
}
