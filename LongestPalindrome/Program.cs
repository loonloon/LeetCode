using System.Collections.Generic;
/*
 * 409. Longest Palindrome
 * https://leetcode.com/problems/longest-palindrome/
 */
namespace LongestPalindrome
{
    class Program
    {
        /*
         * Given a string which consists of lowercase or uppercase letters, find the length of the longest palindromes that can be built with those letters.
         * This is case sensitive, for example "Aa" is not considered a palindrome here.
         *
         * Note:
         * Assume the length of given string will not exceed 1,010.
         *
         * Example:
         * Input: "abccccdd"
         * Output: 7
         *
         * Explanation:
         * One longest palindrome that can be built is "dccaccd", whose length is 7.
         *
         */
        static void Main(string[] args)
        {
            var result = LongestPalindrome("abccccdd");
        }

        public static int LongestPalindrome(string s)
        {
            var hashSet = new HashSet<char>();
            var count = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (hashSet.Contains(s[i]))
                {
                    hashSet.Remove(s[i]);
                    count += 2;
                }
                else
                {
                    hashSet.Add(s[i]);
                }
            }

            return hashSet.Count > 0 ? count + 1 : count;
        }
    }
}
