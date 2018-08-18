using System;

/*
 * 693. Binary Number with Alternating Bits
 * https://leetcode.com/problems/binary-number-with-alternating-bits/description/
 */
namespace HasAlternatingBits
{
    class Program
    {
        /*
         * Given a positive integer, check whether it has alternating bits: namely, if two adjacent bits will always have different values.
         *
         * Example 1:
         * Input: 5
         * Output: True
         * Explanation:
         * The binary representation of 5 is: 101
         *
         * Example 2:
         * Input: 7
         * Output: False
         * Explanation:
         * The binary representation of 7 is: 111.
         *
         * Example 3:
         * Input: 11
         * Output: False
         * Explanation:
         * The binary representation of 11 is: 1011.
         *
         * Example 4:
         * Input: 10
         * Output: True
         * Explanation:
         * The binary representation of 10 is: 1010.
         *
         */
        static void Main(string[] args)
        {
            var result = HasAlternatingBits(5);
            var result2 = HasAlternatingBits(7);
            var result3 = HasAlternatingBits(11);
            var result4 = HasAlternatingBits(10);
        }

        public static bool HasAlternatingBits(int n)
        {
            var binary = Convert.ToString(n, 2);

            for (var i = 0; i < binary.Length - 1; i++)
            {
                if (binary[i] == binary[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
