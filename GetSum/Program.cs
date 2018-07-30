/*
 * 371. Sum of Two Integers
 * https://leetcode.com/problems/sum-of-two-integers/description/
 */
namespace GetSum
{
    class Program
    {
        /*
         * Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -.
         *
         * Example:
         * Given a = 1 and b = 2, return 3.
         *
         */
        static void Main(string[] args)
        {
            var result = GetSum(5, 1);
        }

        public static int GetSum(int a, int b)
        {
            var sum = 0;

            while (b != 0)
            {
                //calculate sum of a and b without thinking the carry
                //5 = 0000 0101
                //1 = 0000 0001
                //sum = 0000 0100 (4)
                sum = a ^ b;

                //calculate the carry
                //5 = 0000 0101
                //1 = 0000 0001
                //b = 0000 0001 (1)
                b = a & b;

                //add sum(without carry) and carry
                a = sum;
            }

            return sum;
        }
    }
}
