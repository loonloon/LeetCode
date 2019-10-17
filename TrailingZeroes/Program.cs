/*
 * 172. Factorial Trailing Zeroes
 * https://leetcode.com/problems/factorial-trailing-zeroes/
 */
namespace TrailingZeroes
{
    class Program
    {
        /*
         * Given an integer n, return the number of trailing zeroes in n!.
         * Example 1:
         * Input: 3
         * Output: 0
         * Explanation: 3! = 6, no trailing zero.
         *
         * Example 2:
         * Input: 5
         * Output: 1
         * Explanation: 5! = 120, one trailing zero.
         * Note: Your solution should be in logarithmic time complexity.
         *
         */
        static void Main(string[] args)
        {
            var result = TrailingZeroes(3);
            var result2 = TrailingZeroes(5);
        }

        public static int TrailingZeroes(int n)
        {
            var result = 0;

            while (n / 5 >= 1)
            {
                result += n / 5;
                n /= 5;
            }

            return result;
        }
    }
}
