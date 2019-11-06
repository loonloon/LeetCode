/*
 * 367. Valid Perfect Square
 */
namespace IsPerfectSquare
{
    class Program
    {
        /*
         * Given a positive integer num, write a function which returns True if num is a perfect square else False.
         * Note: Do not use any built-in library function such as sqrt.
         *
         * Example 1:
         * Input: 16
         * Output: true
         *
         * Example 2:
         * Input: 14
         * Output: false
         *
         */
        static void Main(string[] args)
        {
            var result = IsPerfectSquare(16);
            var result2 = IsPerfectSquare(14);
        }

        public static bool IsPerfectSquare(int num)
        {
            var begin = 1;
            var end = num;

            while (end >= begin)
            {
                var mid = (begin + end) / 2;

                if (mid * mid == num)
                {
                    return true;
                }

                if (mid * mid >= num)
                {
                    end = mid - 1;
                }
                else
                {
                    begin = mid + 1;
                }
            }

            return false;

            //var result = 1;

            //while (num >= (result * result))
            //{
            //    if (num == (result * result))
            //    {
            //        return true;
            //    }

            //    result++;
            //}

            //return false;
        }
    }
}
