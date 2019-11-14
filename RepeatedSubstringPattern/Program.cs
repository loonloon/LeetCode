using System.Text;
/*
 * 459. Repeated Substring Pattern
 * https://leetcode.com/problems/repeated-substring-pattern/
 */
namespace RepeatedSubstringPattern
{
    class Program
    {
        /*
         * Given a non-empty string check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.
         * You may assume the given string consists of lowercase English letters only and its length will not exceed 10000.
         *
         * Example 1:
         * Input: "abab"
         * Output: True
         * Explanation: It's the substring "ab" twice.
         *
         * Example 2:
         * Input: "aba"
         * Output: False
         *
         * Example 3:
         * Input: "abcabcabcabc"
         * Output: True
         * Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)
         *
         */
        static void Main(string[] args)
        {
            var result = RepeatedSubstringPattern("abab");
            var result2 = RepeatedSubstringPattern("aba");
            var result3 = RepeatedSubstringPattern("abcabcabcabc");
        }

        public static bool RepeatedSubstringPattern(string s)
        {
            //why divider is 2? if the repeated string always even number
            var divider = 2;

            while (divider <= s.Length)
            {
                if (s.Length % divider == 0)
                {
                    var chunk = s.Substring(0, s.Length / divider);
                    var result = new StringBuilder();

                    while (result.Length != s.Length)
                    {
                        result.Append(chunk);
                    }

                    if (result.ToString() == s)
                    {
                        return true;
                    }
                }

                divider++;
            }

            return false;
        }
    }
}
