using System;
using System.Text;
/*
 * 482. License Key Formatting
 * https://leetcode.com/problems/license-key-formatting/
 */
namespace LicenseKeyFormatting
{
    class Program
    {
        /*
         * You are given a license key represented as a string S which consists only alphanumeric character and dashes.
         * The string is separated into N+1 groups by N dashes.
         *
         * Given a number K, we would want to reformat the strings such that each group contains exactly K characters,
         * except for the first group which could be shorter than K, but still must contain at least one character.
         * Furthermore, there must be a dash inserted between two groups and all lowercase letters should be converted to uppercase.
         *
         * Given a non-empty string S and a number K, format the string according to the rules described above.
         * Example 1:
         * Input: S = "5F3Z-2e-9-w", K = 4
         * Output: "5F3Z-2E9W"
         * Explanation: The string S has been split into two parts, each part has 4 characters.
         * Note that the two extra dashes are not needed and can be removed.
         *
         * Example 2:
         * Input: S = "2-5g-3-J", K = 2
         * Output: "2-5G-3J"
         * Explanation: The string S has been split into three parts, each part has 2 characters except the first part as it could be shorter as mentioned above.
         *
         */
        static void Main(string[] args)
        {
            var result = LicenseKeyFormatting("5F3Z-2e-9-w", 4);
            var result2 = LicenseKeyFormatting("2-5g-3-J", 2);
        }

        public static string LicenseKeyFormatting(string S, int K)
        {
            var sb = new StringBuilder();
            var charLength = 0;

            for (var i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '-')
                {
                    continue;
                }

                if (charLength > 0 && charLength % K == 0)
                {
                    sb.Append('-');
                }

                sb.Append(char.ToUpper(S[i]));
                charLength++;
            }

            var chars = sb.ToString().ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
