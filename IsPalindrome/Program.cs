/*
 * 9. Palindrome Number
 * https://leetcode.com/problems/palindrome-number/
 */
namespace IsPalindrome
{
    /*
     * Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
     *
     * Example 1:
     * Input: 121
     * Output: true
     *
     * Example 2:
     * Input: -121
     * Output: false
     * Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
     *
     * Example 3:
     * Input: 10
     * Output: false
     * Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            var result = IsPalindrome(121);
            var result2 = IsPalindrome(-121);
            var result3 = IsPalindrome(10);
        }

        public static bool IsPalindrome(int x)
        {
            var original = x;
            var reverse = 0;

            while (x > 0)
            {
                var remainder = x % 10;
                reverse = reverse * 10 + remainder;
                x /= 10;
            }

            return original == reverse;
        }
    }
}
