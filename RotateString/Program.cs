/*
 * 796. Rotate String
 * https://leetcode.com/problems/rotate-string/description/
 */
namespace RotateString
{
    class Program
    {
        /*
         * We are given two strings, A and B.
         * A shift on A consists of taking string A and moving the leftmost character to the rightmost position.
         *
         * For example, if A = 'abcde', then it will be 'bcdea' after one shift on A.
         * Return True if and only if A can become B after some number of shifts on A.
         *
         * Example 1:
         * Input: A = 'abcde', B = 'cdeab'
         * Output: true
         *
         * Example 2:
         * Input: A = 'abcde', B = 'abced'
         * Output: false
         *
         */
        static void Main(string[] args)
        {
            var result = RotateString("abcde", "cdeab");
            var result2 = RotateString("abcde", "abcde");
        }

        public static bool RotateString(string A, string B)
        {
            //"abcdeabcde" (A + A)
            //"cdeab" (B)
            //B is found in (A + A), so B is a rotated string of A.
            return A.Length == B.Length && (A + A).Contains(B);
        }
    }
}
