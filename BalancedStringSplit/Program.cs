/*
 * 1221. Split a String in Balanced Strings
 * https://leetcode.com/problems/split-a-string-in-balanced-strings/
 */
namespace BalancedStringSplit
{
    class Program
    {
        /*
         * Balanced strings are those who have equal quantity of 'L' and 'R' characters.
         * Given a balanced string s split it in the maximum amount of balanced strings.
         * Return the maximum amount of splitted balanced strings.
         *
         * Example 1:
         * Input: s = "RLRRLLRLRL"
         * Output: 4
         * Explanation: s can be split into "RL", "RRLL", "RL", "RL", each substring contains same number of 'L' and 'R'.
         *
         * Example 2:
         * Input: s = "RLLLLRRRLR"
         * Output: 3
         * Explanation: s can be split into "RL", "LLLRRR", "LR", each substring contains same number of 'L' and 'R'.
         *
         * Example 3:
         * Input: s = "LLLLRRRR"
         * Output: 1
         * Explanation: s can be split into "LLLLRRRR".
         *
         * Constraints:
         * 1 <= s.length <= 1000
         * s[i] = 'L' or 'R'
         *
         */
        static void Main(string[] args)
        {
            var result = BalancedStringSplit("RLRRLLRLRL");
            var result2 = BalancedStringSplit("RLLLLRRRLR");
            var result3 = BalancedStringSplit("LLLLRRRR");
        }

        public static int BalancedStringSplit(string s)
        {
            var count = 0;
            var countL = 0;
            var countR = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (countL == countR)
                {
                    count++;
                    countL = 0;
                    countR = 0;
                }

                if (s[i] == 'L')
                {
                    countL++;
                }
                else
                {
                    countR++;
                }
            }

            return count;
        }
    }
}
