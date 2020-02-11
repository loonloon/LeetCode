/*
 * 1281. Subtract the Product and Sum of Digits of an Integer
 * https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
 */
namespace SubtractProductAndSum
{
    class Program
    {
        /*
         * Given an integer number n, return the difference between the product of its digits and the sum of its digits.
         * Example 1:
         * Input: n = 234
         * Output: 15
         * Explanation:
         * Product of digits = 2 * 3 * 4 = 24
         * Sum of digits = 2 + 3 + 4 = 9
         * Result = 24 - 9 = 15
         *
         * Example 2:
         * Input: n = 4421
         * Output: 21
         * Explanation:
         * Product of digits = 4 * 4 * 2 * 1 = 32
         * Sum of digits = 4 + 4 + 2 + 1 = 11
         * Result = 32 - 11 = 21
         *
         * Constraints:
         * 1 <= n <= 10^5
         *
         */
        static void Main(string[] args)
        {
            var result = SubtractProductAndSum(234);
            var result2 = SubtractProductAndSum(4421);
        }

        public static int SubtractProductAndSum(int n)
        {
            var sum = 0;
            var product = 1;

            while (n > 0)
            {
                sum += n % 10;
                product *= n % 10;
                n /= 10;
            }

            return product - sum;
        }
    }
}
