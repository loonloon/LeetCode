/*
 * 202. Happy Number
 * https://leetcode.com/problems/happy-number/description/
 */
namespace IsHappy
{
    class Program
    {
        /*
         * Write an algorithm to determine if a number is "happy".
         *
         * A happy number is a number defined by the following process:
         * Starting with any positive integer, replace the number by the sum of the squares of its digits,
         * and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
         * Those numbers for which this process ends in 1 are happy numbers.
         *
         * Example:
         * Input: 19
         * Output: true
         *
         * Explanation:
         * 12 + 92 = 82
         * 82 + 22 = 68
         * 62 + 82 = 100
         * 12 + 02 + 02 = 1
         *
         */
        static void Main(string[] args)
        {
            var result = IsHappy(19);
        }

        public static bool IsHappy(int n)
        {
            if (10 > n)
            {
                return n == 1 || n == 7;
            }

            var sum = 0;

            while (n > 0)
            {
                var remainder = n % 10;
                sum += remainder * remainder;
                n /= 10;
            }

            return IsHappy(sum);
        }
    }
}
