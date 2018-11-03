/*
 * 7. Reverse Integer
 * https://leetcode.com/problems/reverse-integer/
 */
namespace Reverse
{
    /*
     * Given a 32-bit signed integer, reverse digits of an integer.
     *
     * Example 1:
     * Input: 123
     * Output: 321
     *
     * Example 2:
     * Input: -123
     * Output: -321
     *
     * Example 3:
     * Input: 120
     * Output: 21
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            var result = Reverse(123);
            var result2 = Reverse(-123);
            var result3 = Reverse(120);
        }

        public static int Reverse(int x)
        {
            var result = 0;

            while (x != 0)
            {
                var tail = x % 10;
                var newResult = result * 10 + tail;

                //when overflow return 0, e.g. if the value is 123467899
                if ((newResult - tail) / 10 != result)
                {
                    return 0;
                }

                result = newResult;
                x = x / 10;
            }

            return result;
        }
    }
}
