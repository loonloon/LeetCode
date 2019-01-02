/*
 * 69. Sqrt(x)
 * https://leetcode.com/problems/sqrtx/
 */
namespace MySqrt
{
    class Program
    {
        /*
         * Implement int sqrt(int x).
         * Compute and return the square root of x, where x is guaranteed to be a non-negative integer.
         * Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.
         *
         * Example 1:
         * Input: 4
         * Output: 2
         *
         * Example 2:
         * Input: 8
         * Output: 2
         *
         * Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
         *
         */
        static void Main(string[] args)
        {
            var result = MySqrt(4);
            var result2 = MySqrt(8);
        }

        public static int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            var left = 1;
            var right = int.MaxValue;

            while (true)
            {
                var mid = left + (right - left) / 2;

                if (mid > x / mid)
                {
                    right = mid - 1;
                }
                else
                {
                    if (mid + 1 > x / (mid + 1))
                    {
                        return mid;
                    }

                    left = mid + 1;
                }
            }

            //Newton's method
            //long r = x;

            //while (r * r > x)
            //{
            //    r = (r + x / r) / 2;
            //}

            //return (int)r;
        }
    }
}
