/*
 * 342. Power of Four
 * https://leetcode.com/problems/power-of-four/
 */
namespace IsPowerOfFour
{
    class Program
    {
        /*
         * Given an integer (signed 32 bits), write a function to check whether it is a power of 4.
         *
         * Example 1:
         * Input: 16
         * Output: true
         *
         * Example 2:
         * Input: 5
         * Output: false
         *
         * Follow up: Could you solve it without loops/recursion?
         *
         */
        static void Main(string[] args)
        {
            var result = IsPowerOfFour(4);
            var result2 = IsPowerOfFour(5);
        }

        public static bool IsPowerOfFour(int num)
        {
            //another way is start value from 1, then if num > value every time * 4 and compare

            if (num == 0)
            {
                return false;
            }

            while (num % 4 == 0)
            {
                num /= 4;
            }

            return num == 1;
        }
    }
}
