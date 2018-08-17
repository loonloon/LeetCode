using System.Linq;

namespace IsAnagram
{
    /*
     * 242. Valid Anagram
     * https://leetcode.com/problems/valid-anagram/description/
     */
    class Program
    {
        /*
         * Given two strings s and t , write a function to determine if t is an anagram of s.
         *
         * Example 1:
         * Input: s = "anagram", t = "nagaram"
         * Output: true
         *
         * Example 2:
         * Input: s = "rat", t = "car"
         * Output: false
         *
         * Note:
         * You may assume the string contains only lowercase alphabets.
         *
         * Follow up:
         * What if the inputs contain unicode characters? How would you adapt your solution to such case?
         *
         */
        static void Main(string[] args)
        {
            var result = IsAnagram("anagram", "nagaram");
            var result2 = IsAnagram("rat", "car");
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var alphabets = new short[26];

            for (var i = 0; i < s.Length; i++)
            {
                alphabets[s[i] - 'a']++;
                alphabets[t[i] - 'a']--;
            }

            return !alphabets.Any(alphabet => alphabet > 0);
        }
    }
}
